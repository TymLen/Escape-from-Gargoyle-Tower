using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureUI : MonoBehaviour {

    public Sprite noTreasure;
    public Sprite yesTreasure;
    private AudioSource pickupChime;
    public bool haveTreasure;
    private Image treasureIcon;

	// Use this for initialization
	void Start () {
        haveTreasure = false;
        pickupChime = GetComponent<AudioSource>();
        treasureIcon = GetComponent<Image>();
        treasureIcon.sprite = noTreasure;
        treasureIcon.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TreasureFound()
    {
        haveTreasure = true;
        pickupChime.Play();
        treasureIcon.sprite = yesTreasure;
        treasureIcon.color = Color.green;
    }
}
