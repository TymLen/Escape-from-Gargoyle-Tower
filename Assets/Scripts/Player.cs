using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public KeyCode forwardKey;
    public KeyCode backKey;
    public KeyCode rightKey;
    public KeyCode leftKey;
    public float speed = 10;



	// Use this for initialization

	void Start () {
   
	}
	
	// Update is called once per frame
	void Update () {
        transform.forward = Camera.main.transform.forward;

        if (Input.GetKeyDown(forwardKey))
        {
            GetComponent<Rigidbody>().velocity = Vector3.forward * speed;
        }
        else if(Input.GetKeyDown(backKey))
        {
            GetComponent<Rigidbody>().velocity = -Vector3.forward * speed;
        }
        else if(Input.GetKeyDown(rightKey))
        {
            GetComponent<Rigidbody>().velocity = Vector3.right * speed;
        }
        else if (Input.GetKeyDown(leftKey))
        {
            GetComponent<Rigidbody>().velocity = -Vector3.right * speed;
        }


		
	}
}
