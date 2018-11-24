using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLight : MonoBehaviour 
{
    
    public GameObject lightBullet;
    public Transform bulletSpawner;
    public GameObject roddyGround;

    private float reload = 0f;
    private float reloadTime = 0.4f;
    private bool firing = false;
    private Vector3 rotater;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (reload > 0)
            reload -= Time.deltaTime;
        if (!roddyGround)
        {
            Fire();
            if (Input.GetButtonDown("Fire1"))
            {
                firing = true; 
            }
            if (Input.GetButtonUp("Fire1"))
            {
                firing = false;
            }
        }
    }

    void Fire()
    {
        if (firing == true && reload <=0f)
        {
            GameObject lightball = Instantiate(lightBullet);
            Rigidbody rigidBall = lightball.GetComponent<Rigidbody>();
            lightball.transform.rotation = bulletSpawner.transform.rotation;
            lightball.transform.position = bulletSpawner.transform.position;
            rigidBall.AddForce(bulletSpawner.transform.forward * 1000f);
            Destroy(lightball, 4);
            reload = reloadTime;
        }    
    }
}
