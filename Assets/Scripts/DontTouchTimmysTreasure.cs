using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontTouchTimmysTreasure : MonoBehaviour {

    private Health health;
    public AudioSource growl;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider co)
    {
        health = co.GetComponentInChildren<Health>();
        if (health)
        {
            health.Decrease(10, "Eddy Kisses");
            growl.Play();
        }
    }
}
