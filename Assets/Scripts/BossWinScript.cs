using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWinScript : MonoBehaviour {

    public GameObject rod;
    public GameObject exit;
    public Transform exitPos;
    public GameObject wallyHurt;
    public GameObject wallyHealthy;
    public Transform wallyPos;
    public GameObject treasure;
    public Transform treasurePos;
    public Health health;
    public AudioSource music;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Victory()
    {
        Instantiate(exit, exitPos.position, exitPos.rotation);
        
        if(health.health == 100)
        {
            Instantiate(treasure, treasurePos.position, treasurePos.rotation);
            Instantiate(wallyHealthy, wallyPos.position, wallyPos.rotation);
        }
        else
        {
            Destroy(rod);
            Instantiate(wallyHurt, wallyPos.position, wallyPos.rotation);
        }
    }
}
