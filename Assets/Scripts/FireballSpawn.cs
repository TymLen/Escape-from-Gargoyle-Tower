using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpawn : MonoBehaviour {

    public GameObject fireballPrefab;
    public Transform fireballSpawner;
    public float interval = 3;


    private AudioSource shootNoise;
	// Use this for initialization
	void Start () {
        
        shootNoise = GetComponent<AudioSource>();
        ShootNow();
	}
    void SpawnNext()
    {
        Instantiate(fireballPrefab, fireballSpawner.position, fireballSpawner.rotation);
        shootNoise.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void ShootNow()
    {
        InvokeRepeating("SpawnNext", interval, interval);
    }
}
