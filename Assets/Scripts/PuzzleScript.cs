using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript : MonoBehaviour {

    public Light light1;
    public Light light2;
    public Light light3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeLight(int light, Color inColor)
    {
        light1.color = inColor;
        switch (light)
        {
            case 1:
                light1.color = inColor;
                light1.intensity = 20;
                break;
            case 2:
                light2.color = inColor;
                light2.intensity = 20;
                break;
            case 3:
                light3.color = inColor;
                light3.intensity = 20;
                break;
            default:
                break;
        }
    }
}
