using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject target;

    public GameObject effectsManager;
    public GameObject hitEffect;
    public float effectDuration = 0.1f;

    public AudioClip hitSound;

    protected Effect effectScript;

    // Start is called before the first frame update
    void Awake()
    {
        effectScript = effectsManager.GetComponent<Effect>();
    }

    // Update is called once per frame
    public virtual void Process(RaycastHit hit)
    {
        
    }
}
