using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour {


    public int health = 1000;

    private Slider healthbar;
    private LightBulletPreFab bullet;


    // Use this for initialization

    void Start () {
        healthbar = GetComponent<Slider>();
        healthbar.value = health;
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void Decrease(int damage)
    {
        health = health - damage;
        if (health > 0)
        {
            healthbar.value = health;
        }
        else
        {
            healthbar.value = health;
            Destroy(gameObject);
        }
    }
}
