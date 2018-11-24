using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTester : MonoBehaviour {

    public Slider horiSlide;
    public Slider vertSlide;
    public Text fireText;
    public Text menuText;
    

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw("Horizontal") < 0) 
        {
            horiSlide.value = (float)0.500 + Input.GetAxisRaw("Horizontal");
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            horiSlide.value = (float)0.500 + Input.GetAxisRaw("Horizontal");
        }
        if(Input.GetAxisRaw("Horizontal") == 0)
        {
            horiSlide.value = (float)0.500;
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            vertSlide.value = (float)0.500 + Input.GetAxisRaw("Vertical");
        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {

            vertSlide.value = (float)0.500 + Input.GetAxisRaw("Vertical");
        }
        if(Input.GetAxisRaw("Vertical") == 0)
        {
            vertSlide.value = (float)0.500;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            fireText.color = Color.red;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            fireText.color = Color.black;
        }
        if (Input.GetButtonDown("Cancel"))
        {
            menuText.color = Color.red;
        }
        if (Input.GetButtonUp("Cancel"))
        {
            menuText.color = Color.black;
        }
      
    }
}
