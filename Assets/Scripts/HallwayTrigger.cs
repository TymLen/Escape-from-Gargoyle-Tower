using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayTrigger : MonoBehaviour {
    public GameObject[] hallTraps;
    public Canvas fredTalks;

    private Health health;

    void OnTriggerEnter(Collider co)
    {
        health = co.GetComponentInChildren<Health>();
        if (health)
        {
            for(int i = 0; i < hallTraps.Length; i++)
            {
                Destroy(hallTraps[i]);
            }
            fredTalks.enabled = true;
            PlayerStats.Set2Check(true);
        }
    }
    void OnTriggerExit(Collider co)
    {
        health = co.GetComponentInChildren<Health>();
        if (health)
        {
            fredTalks.enabled = false;
        }
    }
}
