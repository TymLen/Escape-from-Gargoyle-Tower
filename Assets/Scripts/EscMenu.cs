using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EscMenu : MonoBehaviour {

    public Canvas menuCanvas;
    public Canvas hudCanvas;
    public Button[] buttonGroup;
    public ShowLoadMenu showLoad;
    public Image stateImage;
    public Text stateText;
    public Transform hideHere;
    public GameObject escPanel;
    public Transform showHere;

    private Color defColor; 
    private bool unpause = true;
  

    // Use this for initialization
    void Start () {
        menuCanvas.enabled = false;
        EscInteract(false);
        escPanel.transform.position = showHere.position;
        defColor.a = 0;

        if (SceneManager.GetActiveScene().name.Equals("Level2"))
        {
            ChangeState("Objective: Cross the Lava");    
        }

        else if (SceneManager.GetActiveScene().name.Equals("Level1"))
        {
            ChangeState("Objective: Use the device infront of the tower");
        }
        else if (SceneManager.GetActiveScene().name.Equals("Intermission"))
        {
            ChangeState("Objective: Escape with the Staff");
        }
        else if (SceneManager.GetActiveScene().name.Equals("Level3"))
        {
            ChangeState("Objective: Defeat the Darkness");
        }
        else
        {
            ChangeState("Objective: Unknown");
        }
        if (Time.timeScale == 0f)
            Time.timeScale = 1f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("escape") || Input.GetKeyDown("joystick button 3"))
        {
            if (unpause == true)
            {
                if (menuCanvas.enabled == true && Time.timeScale == 0) //If EscMenu is open, close
                {
                    OpenMenu(false);
                    Time.timeScale = 1;
                }
                else if(menuCanvas.enabled == false && Time.timeScale == 1)
                {
                    Time.timeScale = 0;
                    OpenMenu(true);
                }
            }
            
        }
	}
    void OnEnabled()
    {
        buttonGroup[0].Select();

    }

    public void OpenMenu(bool openThis)
    {
        menuCanvas.enabled = openThis;
        hudCanvas.enabled = !openThis;

        EscInteract(openThis);
        if (openThis)
        {
            buttonGroup[0].Select();
            HideMenu(!openThis);  
        }
    }
    public void DontUnpause()
    {
        
        showLoad.LoadInteract(false);
        EscInteract(true);
        buttonGroup[0].Select();
        unpause = false;
        Time.timeScale = 0;
        OpenMenu(true);
    }

    public void HideMenu(bool hideThis)
    {
        if (hideThis)
        {
            escPanel.transform.position = hideHere.position;
            EscInteract(false);
        }
        else if (!hideThis)
        {
            escPanel.transform.position = showHere.position;
            EscInteract(true);
        }
    }

    public void ResumeButton()
    {
        if(unpause == true)
        {
            Time.timeScale = 1f;
            OpenMenu(false);
        } 
    }


    public void ChangeState(string inText)
    {
        stateText.text = inText;
    }
    public void EscInteract(bool inState)
    {
        for (int i = 4; i < buttonGroup.Length; i++)
        {
            buttonGroup[i].interactable = inState;
        }
    }
    public void EndLevel()
    {
        Application.Quit();
    }
    public void RestartLevel()
    {
        Debug.Log(SceneManager.GetActiveScene());
        if (SceneManager.GetActiveScene().name.Equals("Level2"))
        {
            PlayerStats.IncLevel2Death();
            Debug.Log("Level3 Attempted");
        }
        if (SceneManager.GetActiveScene().name.Equals("Level3"))
        {
            PlayerStats.IncLevel3Death();
            Debug.Log("Level3 Attempted");
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
