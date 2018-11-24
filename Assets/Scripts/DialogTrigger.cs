using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour {


    public Canvas talkWords;
    public Collider ball;
    public bool sleeping = false;

    private Health health;
    private AudioSource mouthNoises;
    

    // Use this for initialization
    void Start () {
        mouthNoises = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider co)
    {
        if (!sleeping)
        {
            health = co.GetComponentInChildren<Health>();
            if (health)
            {
                mouthNoises.Play();
                talkWords.enabled = true;
                if (ball)
                    ball.enabled = true;
            }
        }
        
    }
    void OnTriggerExit(Collider co)
    {
        health = co.GetComponentInChildren<Health>();
        if(health)
        {
            mouthNoises.Stop();
            talkWords.enabled = false;
        }
    }
}
