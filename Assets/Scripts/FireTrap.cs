using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrap : MonoBehaviour {

    private Health health;
    private AudioSource painNoise;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, 1.0f);
        painNoise = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider co)
    {
        health = co.GetComponentInChildren<Health>();
        if (health)
        {
            health.DecreaseOverTime(0.5f, true);
            painNoise.Play();
        }
    }
    void OnTriggerExit(Collider co)
    {
        health = co.GetComponentInChildren<Health>();
        if (health)
        {
            health.DecreaseOverTime(0.0f, false);
        }
    }
    void OnDestroy()
    {
        if(health)
        health.DecreaseOverTime(0.0f, false);
    }
}
