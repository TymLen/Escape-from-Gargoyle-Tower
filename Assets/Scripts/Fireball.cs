using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

    public float speed = 5;
    public float damage = 25;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision co)
    {
        Health health = co.collider.GetComponentInChildren<Health>();
        if (health)
        {
            health.Decrease(25, "Fireball");
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
}
