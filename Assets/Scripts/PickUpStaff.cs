using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpStaff : MonoBehaviour {

    public Renderer staffHeld;
    public ParticleSystem theDarkness;
    public ParticleSystem theLight;
    public GameObject sassy;
    public Light exitHL;
    public Text helpText;
    public Transform moveHere;

    private Health health;
    private Text sassySays;

	// Use this for initialization
	void Start () {
        sassySays = sassy.GetComponentInChildren<Text>();
        staffHeld.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider co)
    {

        health = co.GetComponentInChildren<Health>();
        if (health)
        {
            sassySays.text = "\"If you try to leave with the rod you will unleash \n " +
                "an evil and you will not leave unscathed.\" \n";
            staffHeld.enabled = true;
            theLight.Stop();
            Destroy(gameObject);
            exitHL.intensity = 10;
            helpText.text = "Hold or press fire to shoot";
            sassy.transform.position = moveHere.position;
            sassy.transform.LookAt(2* sassy.transform.position - co.transform.position);
        }
    }

}
