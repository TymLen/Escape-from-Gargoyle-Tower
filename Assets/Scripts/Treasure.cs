﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider co)
    {
        TreasureUI treasureUI = co.GetComponentInChildren<TreasureUI>();
        if (treasureUI)
        {
            treasureUI.TreasureFound();
            Destroy(gameObject);

        }
    }
}
