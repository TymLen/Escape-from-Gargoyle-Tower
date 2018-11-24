using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockExit : MonoBehaviour {

    public ParticleSystem theDark;
    public Light exitHL;

    private LightBulletPreFab bullet;
    private Health health;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider co)
    {
        bullet = co.GetComponent<LightBulletPreFab>();
        health = co.GetComponent<Health>();
        if (bullet)
        {
            Destroy(gameObject);
            theDark.Stop();
            exitHL.color = Color.white;
        }
        if(health)
        {
            health.Decrease(20, "Dark Energy");
        }
    }
}
