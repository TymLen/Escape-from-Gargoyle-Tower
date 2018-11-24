using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuScript : MonoBehaviour {

    public Canvas mainCanvas;
    public Canvas testerCanvas;
    public LoadMenu_Main loadMenu;
    public Canvas contractCanvas;
    public Button[] mmButs;
    public Button[] contractButs;
    public Button testerBut;

    // Use this for initialization
    void Start()
    {
        Profile check = SaveLoad.LoadProfile();
        if(check.firstGame == true)
        {
            PlayHow(true);
            check.firstGame = false;
            SaveLoad.Save(check);
        }
        else
        {
            ShowMM(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMM(bool show)
    {
        mainCanvas.enabled = show;
        ButtonState(mmButs, show);
        ButtonState(contractButs, !show);
        loadMenu.ShowMenu(!show);
    }
    public void ButtonState(Button[] inButs ,bool inState)
    {
        for (int i = 0; i < inButs.Length; i++)
        {
            inButs[i].interactable = inState;
        }
        if (inState == true)
        {
            inButs[0].Select();
        }
    }
    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
        SaveLoad.DeleteProfile();
        Profile newGame = SaveLoad.LoadProfile();
        newGame.firstGame = false;
        newGame.levelOne.locked = false;
        SaveLoad.Save(newGame);
    }

    public void PlayHow(bool learn)
    {
        ButtonState(mmButs, !learn);
        mainCanvas.enabled = !learn;
        testerCanvas.enabled = learn;
        if (learn)
            testerBut.Select();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void SignTheContract(bool signed)
    {
        ButtonState(mmButs, !signed);
        ButtonState(contractButs, signed);
        mainCanvas.enabled = !signed;
        contractCanvas.enabled = signed;
        
        if (signed)
        {
            contractButs[0].Select();
        }
        if (!signed)
        {
            loadMenu.ShowMenu(false);
        }
    }
}
