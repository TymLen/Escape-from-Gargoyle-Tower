using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotDead : MonoBehaviour {

    private Canvas gameOver;

	// Use this for initialization
	void Start () {
        gameOver = GetComponent<Canvas>();
        gameOver.enabled = gameOver.enabled;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
