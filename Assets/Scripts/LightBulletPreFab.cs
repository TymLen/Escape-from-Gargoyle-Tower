using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulletPreFab : MonoBehaviour {

    public int speed = 6;
    public int damage = 10;

    private BossHealth bosshealth;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider co)
    {
        bosshealth = co.GetComponentInChildren<BossHealth>();
        if (bosshealth)
        {
            bosshealth.Decrease(damage);
            Destroy(gameObject);
        }
    }
}
