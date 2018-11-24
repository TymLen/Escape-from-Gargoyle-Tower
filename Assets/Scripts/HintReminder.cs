using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HintReminder : MonoBehaviour {

    public Text hintText;

    private float timer = 180;

    void Start()
    {
        if (SceneManager.GetActiveScene().name.Equals("Level2"))
        {
            if(PlayerStats.GetLevel2Attempts() == 3)
            {
                hintText.text = "Hints available in menu";
                timer = 10;
            }
        }
    }
	// Update is called once per frame
	void Update () {
		if(timer > 0)
        {
            timer= timer - Time.deltaTime;
        }
        else if(timer <= 0)
        {
            if (hintText.text.Equals(""))
            {
                hintText.text = "Hints available in menu";
                timer = 10;
            }
            else if(hintText.text.Equals("Hints available in menu"))
            {
                hintText.text = "";
                timer = 120;
            }  
        }
	}
}
