using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HelpMe : MonoBehaviour {

    public EscMenu escScript;
    public Text helpText;
    public Text helpTreaText;
    public GameObject helpPanel;
    public Transform showHere;
    public Transform hideHere;
    public Button[] helpButtons;


    private List<string> treaHints = new List<string>();
    private int hintIndex = 0;
    private int treasureIndex = 0;
    private List<string> levelHints = new List<string>();

    // Use this for initialization
    void Start () {
        helpPanel.transform.position = hideHere.position;
        ActiveButtons(false);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenHelp()
    {
        GetHelp();
        helpPanel.transform.position = showHere.position;
        ActiveButtons(true);
        escScript.HideMenu(true);
    }

    public void CloseHelp()
    {
        helpPanel.transform.position = hideHere.position;
        //escScript.HideMenu(false);
        ActiveButtons(false);
        escScript.OpenMenu(true);
    }

    public void LevelHelp()
    {

        
        if(hintIndex < levelHints.Count)
        {
            helpText.text = levelHints[hintIndex];
            hintIndex++;
        }
            
    }
    public void TreasureHelp()
    {
        if (treasureIndex < treaHints.Count)
            helpTreaText.text = treaHints[treasureIndex];
            treasureIndex++;
    }

    public void GetHelp()
    {
        levelHints = new List<string>();
        treaHints = new List<string>();
        hintIndex = 0;
        treasureIndex = 0;
        if (SceneManager.GetActiveScene().name.Equals("Level1"))
        {
            levelHints.Add("Walk into the device infront of the tower.");
            levelHints.Add("The light needs to be \"pure\".");
            levelHints.Add("Select one of each crystal and then activate. \n");
            levelHints.Add("Walk into the tower's doorway to \n"+"complete the level.");
            treaHints.Add("To the right of the tower is a gargoyle. \n");
            treaHints.Add("Walk towards the gargoyle until he speaks. \n");
            treaHints.Add("Return towards the start of the level and to\n" + "the right is a ball.");
            treaHints.Add("Walk into the ball to pick it up.");
            treaHints.Add("You need to make the ball green.");
            treaHints.Add("Use the device.");
            treaHints.Add("Put an emerald into each slot and walk into \n" + "the light.");
            treaHints.Add("Return the green ball to the gargoyle and walk\n" + "into the treasure."); 
        }
        else if (SceneManager.GetActiveScene().name.Equals("Level2"))
        {
            levelHints.Add("Fire hurts. Avoid the fire.");
            levelHints.Add("You need brains to get across the lava\n" + "but also eyes.");
            levelHints.Add("Look up to see the path across the lava.");
            levelHints.Add("Staying on the path is more important\n" + "than not getting hit.");
            treaHints.Add("If you are not sure how to get past\n" + "the lava, see level hints");
            treaHints.Add("To get to the treasure requires\n" + "a leap of faith.");
            treaHints.Add("The gargoyle says to try where\n" + "the path to the treasure is shortest.");
            treaHints.Add("Try walking towards the treasure\n" + "at the last bend");
        }
        else if (SceneManager.GetActiveScene().name.Equals("Intermission"))
        {
            levelHints.Add("You cannot leave without the rod");
            levelHints.Add("The darkness is blocking the exit");
            levelHints.Add("The rod shoots light");
            levelHints.Add("Shoot the darkness with the rod");
            treaHints.Add("The rod is the treasure");
        }
        else if (SceneManager.GetActiveScene().name.Equals("Level3"))
        {
            levelHints.Add("You must defeat the darkness. \n"+"There is no revelry in the dark");
            levelHints.Add("The light rod is super effective \n" + "against dark types");
            levelHints.Add("Reduce the boss health to 0\n" + "while keeping yours above 0.");
            levelHints.Add("strafing from side to side is effective.");
            treaHints.Add("The gargoyle said you will not\n" + "leave unscathed");
            treaHints.Add("Defeat the boss with full health.");

        }
    }

    public void ActiveButtons(bool active)
    {
        for (int i = 0; i < helpButtons.Length; i++)
        {
            helpButtons[i].enabled = active;
        }
        if (active)
            helpButtons[0].Select();

    }
}
