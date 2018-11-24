using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaLight : MonoBehaviour {

    public float brightRate = 0.1f;
    private Light lavaLight;
    

	// Use this for initialization
	void Start () {
        lavaLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		if(lavaLight.intensity < 10)
        {
            lavaLight.intensity += brightRate;
        }
        else
        {
            lavaLight.intensity = Random.Range(0f, 9f);
        }
	}
}
