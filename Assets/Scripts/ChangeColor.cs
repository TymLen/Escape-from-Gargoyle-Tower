using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour {

    public Light light1;
    public Light light2;
    public Light light3;
    public Text text1;
    public Text text2;
    public Text text3;
    public GameObject exitPortal;
    public GameObject block;
    public GameObject darkness;
    public Rigidbody player;
    public PuzzleLock puzzleLock;
    public Text objUpdate;

    private string[] colorWheel = { "ruby", "emerald", "sapphire" };
    private int colorNo1 = -1;
    private int colorNo2 = -1;
    private int colorNo3 = -1;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeLight1()
    {

        colorNo1++;
        if (colorNo1 == 3)
            colorNo1 = 0;
        text1.text = "The first slot contains a " + colorWheel[colorNo1];
        switch (colorNo1)
        {
            case 0:
                light1.color = Color.red;
                break;
            case 1:
                light1.color = Color.green;
                break;
            case 2:
                light1.color = Color.blue;
                break;
            default:
                break;
        }
    }
    public void ChangeLight2()
    {

        colorNo2++;
        if (colorNo2 == 3)
            colorNo2 = 0;
        text2.text = "The second slot contains a " + colorWheel[colorNo2];
        switch (colorNo2)
        {
            case 0:
                light2.color = Color.red;
                break;
            case 1:
                light2.color = Color.green;
                break;
            case 2:
                light2.color = Color.blue;
                break;
            default:
                break;
        }
    }
    public void ChangeLight3()
    {

        colorNo3++;
        if (colorNo3 == 3)
            colorNo3 = 0;
        text3.text = "The first slot contains a " + colorWheel[colorNo3];
        switch (colorNo3)
        {
            case 0:
                light3.color = Color.red;
                break;
            case 1:
                light3.color = Color.green;
                break;
            case 2:
                light3.color = Color.blue;
                break;
            default:
                break;
        }
    }
    public void PuzzleComplete()
    {
        if(light1.color == Color.red || light2.color == Color.red || light3.color == Color.red)
        {
            if(light1.color == Color.blue || light2.color == Color.blue || light3.color == Color.blue)
            {
                if(light1.color == Color.green || light2.color == Color.green || light3.color == Color.green)
                {
                    Destroy(block);
                    Destroy(darkness);
                    objUpdate.text = "Objective: Enter the Tower";
                }
            }
        }
 
        player.constraints = RigidbodyConstraints.None;
        player.constraints = RigidbodyConstraints.FreezeRotation;
        puzzleLock.ActivatePuzzle(false);

    }
}
