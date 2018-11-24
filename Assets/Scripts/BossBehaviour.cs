using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour {

    public Transform hero;
    public BossHealth bHealth;
    public ShootDark[] shootArray;
    public BossWinScript bossWin;
    public ParticleSystem darkBreath;
    public Transform startPos;
    public Transform fightPos;
    public GameObject shooters;
    public GameObject healthBar;
    public Collider bossHit;

    private int phase = 0;
    private float speed = 1.0f;
    private float deadSpeed = 2f;




	// Use this for initialization
	void Start () {
        if(PlayerStats.GetLevel3Attempts() == 1)
        {
            speed = 2.0f;
        }
        if(PlayerStats.GetLevel3Attempts() >= 2)
        {
            speed = 3.0f;
        }
        this.transform.position = startPos.transform.position;
        bossHit.enabled = false;
        darkBreath.Stop();
    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(2 * transform.position - hero.position);
        if (phase == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, fightPos.position, Time.deltaTime * speed);
            if (transform.position == fightPos.position)
            {
                phase = 1;
                shootArray[0].EnableShoot();
                bossHit.enabled = true;
            }
                
        }      
        else if(bHealth.health <=666 && phase == 1)
        {
            shootArray[1].EnableShoot();
            phase = 2;
        }
        else if(bHealth.health <=333 && phase == 2)
        {
            shootArray[2].EnableShoot();
            darkBreath.Play();
            phase = 3;
        }
        else if(bHealth.health <=0 && phase == 3)
        {
            phase = 4;
            bossWin.Victory();
            Destroy(shooters);
            Destroy(healthBar);
        }
        else if(phase == 4)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos.position, Time.deltaTime * deadSpeed);

            if (transform.position == startPos.position)
            {
                Destroy(gameObject);
            }
        }
	}
}
