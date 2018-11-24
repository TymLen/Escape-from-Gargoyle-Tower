using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadMenu_Main : MonoBehaviour {

    public Canvas loadCanvas;
    public Image treaIcon1;
    public Image completeIcon1;
    public Image treaIcon2;
    public Image completeIcon2;
    public Image treaIcon3;
    public Image completeIcon3;
    public Button[] loadButs;

    private Profile profile;
    private bool confirm = false;
    

    void Start()
    {
        LoadInteract(false);
        loadCanvas.enabled = false;
    }

    public void ShowMenu(bool activated)
    {
        if (activated == true)
        {
            profile = SaveLoad.LoadProfile();
            LoadInteract(true);
            
            

            loadCanvas.enabled = true;
            completeIcon1.enabled = profile.levelOne.GetComplete();
            treaIcon1.enabled = profile.levelOne.GetTreasure();

            completeIcon2.enabled = profile.levelTwo.GetComplete();
            treaIcon2.enabled = profile.levelTwo.GetTreasure();

            completeIcon3.enabled = profile.levelThree.GetComplete();
            treaIcon3.enabled = profile.levelThree.GetTreasure();

            if (profile.levelOne.locked == true)
            {
                loadButs[0].interactable = false;
                loadButs[0].GetComponentInChildren<Text>().color = Color.grey;
            }

            if (profile.levelTwo.locked == true)
            {
                loadButs[1].interactable = false;
                loadButs[1].GetComponentInChildren<Text>().color = Color.grey;
            }

            if (profile.levelThree.locked == true)
            {
                loadButs[2].interactable = false;
                loadButs[2].GetComponentInChildren<Text>().color = Color.grey;
            }
            if (loadButs[0].interactable == false)
            {
                loadButs[3].Select();
            }
            if (loadButs[0].interactable == true)
            {
                loadButs[0].Select();
            }
        }
        else if(activated == false)
        {
            LoadInteract(false);
            loadCanvas.enabled = false;
        }
        
    }
    public void LoadInteract(bool inState)
    {
        for (int i = 0; i < 4; i++)
        {
            loadButs[i].interactable = inState;
        }
    }
    public void Load(string level)
    {
        profile = SaveLoad.LoadProfile();
        if (level.Equals("Level1"))
        {
            if (profile.levelOne.locked == false)
            {
                SceneManager.LoadScene(level);
            }
        }
        if (level.Equals("Level2"))
        {
            if (profile.levelTwo.locked == false)
            {
                SceneManager.LoadScene(level);
            }
        }
        if (level.Equals("Level3"))
        {
            if (profile.levelThree.locked == false)
            {
                SceneManager.LoadScene(level);
            }
        }
    }
    public void DeleteProfile()
    {
        if (!confirm)
        {
            loadButs[4].GetComponentInChildren<Text>().text = "Are you sure?";
            confirm = true;
        }
        if (confirm)
        {   
            SaveLoad.DeleteProfile();
            ShowMenu(true);
            loadButs[4].GetComponentInChildren<Text>().text = "Delete Profile";
            confirm = false;

        }
        
    }
}
