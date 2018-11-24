using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour {

    public GameObject lightBeamPrefab;
    public float interval = 3;
    public KeyCode firebutton;
    // Use this for initialization
    void Start () {
        
    }
    void SpawnNext()
    {
        Instantiate(lightBeamPrefab, transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(firebutton))
        {
            SpawnNext();
        }
        
    }
}
