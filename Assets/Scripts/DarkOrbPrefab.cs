using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkOrbPrefab : MonoBehaviour {

    public int speed = 6;
    public int damage = 25;

    // Use this for initialization
    void Start () {
        this.GetComponent<Rigidbody>().velocity = this.transform.forward * speed;
        this.GetComponent<AudioSource>().Play();
        Destroy(gameObject, 2.0f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider co)
    {
        Health health = co.GetComponentInChildren<Health>();
        if (health)
        {
            health.Decrease(25, "Dark Orb");
            Destroy(gameObject);
        }
    }
}
