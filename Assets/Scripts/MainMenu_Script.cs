using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu_Script : MonoBehaviour {

    public Canvas mainCanvas;
    public Canvas testerCanvas;

    private Button[] mainButs;
    private bool selected = false;

	// Use this for initialization
	void Start () {
        mainCanvas.enabled = true;
        mainButs = mainCanvas.GetComponentsInChildren<Button>(true);
        ButtonState(true);
    }
	
	// Update is called once per frame
	void Update () {
        if (selected == false)
        {
            mainButs[0].Select();
            selected = true;
        }
	}

    public void ButtonState(bool inState)
    {
        for(int i =0; i < mainButs.Length; i++)
        {
            mainButs[i].interactable = inState;
        }
        if(inState == true)
        {
            selected = false;
        }
    }
    
    public void PlayHow(bool learn)
    {
        ButtonState(!learn);
        mainCanvas.enabled = !learn;
        testerCanvas.enabled = learn;
    }
}
