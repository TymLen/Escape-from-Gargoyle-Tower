using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

    
    public GameObject escObject;
    public float health = 100;
    public AudioSource[] hurtNoises;
    public AudioSource pain;
    public AudioSource scream;

    private EscMenu escMenu;
    private Color colorDie;
    private Slider healthbar;
    private float dot;
    private bool dotActive = false;
    // Use this for initialization

    void Start () {
        healthbar = GetComponent<Slider>();
        healthbar.value = health;
        hurtNoises = GetComponents<AudioSource>();
        pain = hurtNoises[0];
        scream = hurtNoises[1];
        escMenu = escObject.GetComponent<EscMenu>();
        colorDie.r = 0.2F;
        colorDie.a = 0.5f;
    }
	
	// Update is called once per frame
	void Update () {

        if (dotActive)
        {
            health -= dot;
            healthbar.value = health;

            if (health <= 0)
            {
                healthbar.value = 0;
                escMenu.DontUnpause();
                Time.timeScale = 0;
                scream.Play();
                escMenu.ChangeState("Cause of Death: Fire Trap");
            }
        }
        
	}
    public void Decrease(float damage, string source)
    {
        health -= damage;
        if (health > 0)
        {
            healthbar.value = health;
            pain.Play();
        }
        else
        {
            healthbar.value = health;
            escMenu.DontUnpause();
            Time.timeScale = 0;
            scream.Play();
            escMenu.ChangeState("Cause of Death: "+source);
            if(SceneManager.GetActiveScene().name.Equals("Level3"))
            {
                Debug.Log("Level3Death");
                PlayerStats.IncLevel3Death();
            }
            if (SceneManager.GetActiveScene().name.Equals("Level2"))
            {
                Debug.Log("Level2Death");
                PlayerStats.IncLevel2Death();
            }
        }
    }

    public void DecreaseOverTime(float damage, bool active)
    {
        dot = damage;
        dotActive = active;
    }
}
