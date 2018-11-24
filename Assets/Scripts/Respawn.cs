using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    public GameObject hero;
	// Use this for initialization
	void Start () {
		if(PlayerStats.Get2Check() == true)
        {
            hero.transform.position = this.transform.position;
        }
	}
}
