using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowLoadMenu : MonoBehaviour
{

    public Canvas menuCanvas;
    public Button level1But;
    public Image[] treaIcons;
    public Image[] completeIcons;
    public Image[] lockedIcons;
    public Button level2But;
    public Button level3But;
    public Button[] loadButs;
    public Transform showHere;
    public Transform hideHere;
    public GameObject loadPanel;
    public Text deleteText;

    private Profile profile;
    private bool confirm = false;



    void Start()
    {
        loadPanel.transform.position = hideHere.position;
    }

    public void ShowMenu()
    {
        loadPanel.transform.position = showHere.position;
        LoadInteract(true);
        profile = SaveLoad.LoadProfile();
        menuCanvas.GetComponent<Canvas>().enabled = true;
        treaIcons[0].enabled = profile.levelOne.GetTreasure();
        treaIcons[1].enabled = profile.levelTwo.GetTreasure();
        treaIcons[2].enabled = profile.levelThree.GetTreasure();
        completeIcons[0].enabled = profile.levelOne.GetComplete();
        completeIcons[1].enabled = profile.levelTwo.GetComplete();
        completeIcons[2].enabled = profile.levelThree.GetComplete();
        lockedIcons[0].enabled = profile.levelOne.locked;
        lockedIcons[1].enabled = profile.levelTwo.locked;
        lockedIcons[2].enabled = profile.levelThree.locked;
    }
    public void HideMenu()
    {
        loadPanel.transform.position = hideHere.position;
        LoadInteract(false);
    }
    public void LoadInteract(bool inState)
    {

        for (int i = 0; i < loadButs.Length; i++)
        {
            loadButs[i].interactable = inState;
        }
        if (inState)
            loadButs[0].Select();
    }
    public void DeleteProfile()
    {
        if (!confirm)
        {
            deleteText.text = "Confirm Delete";
            confirm = true;
        }
        else if (confirm)
        {
            SaveLoad.DeleteProfile();
            confirm = false;
            ShowMenu();
        }
    }
    public void LoadLevel(string level)
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
    void RefreshMenu()
    {
        menuCanvas.GetComponent<Canvas>().enabled = false;
        menuCanvas.GetComponent<Canvas>().enabled = true;
    }
    void Update()
    {

    }
}
