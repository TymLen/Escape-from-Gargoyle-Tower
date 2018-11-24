using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBall : MonoBehaviour {

    public GameObject whiteBallHeld;
    public GameObject RedBallHeld;
    public Light light1;
    public Light light2;
    public Light light3;
    private Renderer whiteBallRend;
    private Renderer redBallRend;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider co)
    {
        if(light1.color == Color.green && light2.color == Color.green && light3.color == Color.green)
        {
            whiteBallRend = whiteBallHeld.GetComponent<Renderer>();
            if (whiteBallRend.enabled == true)
            {
                redBallRend = RedBallHeld.GetComponent<Renderer>();
                redBallRend.enabled = true;
                whiteBallRend.enabled = false;
            }
        }
    }
}
