using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public Renderer whiteball;

    private Health health;

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
            if(whiteball.enabled == true)
            {
                GetComponent<AudioSource>().Play();
                Debug.Log("Cheer");
            }
        }
    }
}
