using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTraps : MonoBehaviour {

    public GameObject[] traps;

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
            for(int i = 0; i < traps.Length; i++)
            {
                Destroy(traps[i]);
            }
        }
    }
}
