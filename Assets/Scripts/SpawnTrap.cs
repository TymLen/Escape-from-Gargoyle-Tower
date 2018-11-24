using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrap : MonoBehaviour {

    public GameObject fireTrapPrefab;
    public Transform fireTrapSpawner;
    public float interval = 3;
    private AudioSource shootNoise;

    // Use this for initialization
    void Start () {
        InvokeRepeating("SpawnNext", interval, interval);
        shootNoise = GetComponent<AudioSource>();
    }
	void SpawnNext()
    {
        Instantiate(fireTrapPrefab, fireTrapSpawner.position, fireTrapSpawner.rotation);
        shootNoise.Play();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
