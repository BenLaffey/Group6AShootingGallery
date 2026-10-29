using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject fpsController;
    public GameObject terrain;

    public bool UseSpawnRange = false;

    public float SpawnX = 0f;
    public float SpawnY = 0f;
    public float SpawnZ = 0f;

    SpawnPoint spawnpoint;

    void Start()
    {
        spawnpoint = new SpawnPoint();
        spawnpoint.SpawnToSinglePoint = !UseSpawnRange;
        spawnpoint.SpawnAtX = SpawnX;
        spawnpoint.SpawnAtY = SpawnY;
        spawnpoint.SpawnAtZ = SpawnZ;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Vector3 position = spawnpoint.Generate(other.gameObject, terrain);
            MoveTo(other.gameObject, position);
        }
    }

    void MoveTo(GameObject player, Vector3 position)
    {
        CharacterController controllerScript = player.GetComponent<CharacterController>();
        controllerScript.enabled = false;
        player.transform.position = position;
        controllerScript.enabled = true;
    }
}
