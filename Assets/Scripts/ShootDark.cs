using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootDark : MonoBehaviour {

    public GameObject darkOrbPrefab;
    public Transform darkOrbSpawner;
    public float interval = 3;
    public Transform hero;
    public GameObject eye;


    // Use this for initialization
    void Start () {
        

    }

    void SpawnNext()
    {
        Instantiate(darkOrbPrefab, darkOrbSpawner.position, darkOrbSpawner.rotation);
    }

    // Update is called once per frame
    void Update () {
        transform.LookAt(hero);
	}

    public void EnableShoot()
    {
        Instantiate(darkOrbPrefab, darkOrbSpawner.position, darkOrbSpawner.rotation);
        InvokeRepeating("SpawnNext", interval, interval);
        eye.GetComponent<Renderer>().enabled = true;
        eye.GetComponent<Light>().intensity = 5;
    }
}
