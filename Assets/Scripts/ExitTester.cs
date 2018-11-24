using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitTester : MonoBehaviour {

    public MainMenuScript mainMenu;
    public Canvas testerCanvas;

    private Text fireConfirm;
    private int counter = 5;

    // Use this for initialization
    void Start () {
        fireConfirm = GetComponent<Text>();
        fireConfirm.text = "Press fire " + counter + " more times to exit";
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && testerCanvas.enabled == true){
            counter -= 1;
            fireConfirm.text = "Press fire " + counter + " more times to exit";
            if (counter == 0)
            {
                counter = 5;
                fireConfirm.text = "Press fire " + counter + " more times to exit";
                mainMenu.PlayHow(false);
            }
        }
	}
}
