using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnBall : MonoBehaviour {

    public GameObject whiteBallHeld;
    public GameObject redBallHeld;
    public GameObject returnedBall;
    public Text timmySays;
    public GameObject hurtBox;

    public GameObject talkTrigger;

    private Renderer whiteRend;
    private Renderer redRend;
    private Renderer returnedRend;

	// Use this for initialization
	void Start () {
        returnedRend = returnedBall.GetComponent<Renderer>();
        returnedRend.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider co)
    {
        whiteRend = whiteBallHeld.GetComponent<Renderer>();
        redRend = redBallHeld.GetComponent<Renderer>();
        returnedRend = returnedBall.GetComponent<Renderer>();
        if(whiteRend.enabled == true)
        {
            timmySays.text = "You approach with the ball in hand and \n"+
                "the sad whisper says \n"+
                "\"My ball has changed from the sunlight\"\n"+
                "\"Can you make it green again?\"";
        }
        else if(redRend.enabled == true)
        {
            redRend.enabled = false;
            returnedRend.enabled = true;
            if (hurtBox)
            {
                Destroy(hurtBox);
            }
            timmySays.text = "After you place the green ball \n"+
                "back into its mouth, it becomes \n" +
                "quiet and you begin wondering \n" +
                "if it ever spoke at all.";
            talkTrigger.GetComponent<AudioSource>().Stop();
            talkTrigger.GetComponent<DialogTrigger>().sleeping = true;
        }
    }
}
