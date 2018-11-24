using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGround : MonoBehaviour {
    public GameObject whiteBall;
    private Health health;
    private Renderer ballRender;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider co)
    {
            
        ballRender = whiteBall.GetComponent<Renderer>();
        ballRender.enabled = true;
        Destroy(gameObject);
    }
}
