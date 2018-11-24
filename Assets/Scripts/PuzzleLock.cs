using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleLock : MonoBehaviour {

    private Rigidbody player;
    private Button[] puzzleButs;
    public Canvas puzzleScreen;

	// Use this for initialization
	void Start () {
        puzzleButs = puzzleScreen.GetComponentsInChildren<Button>();
        ActivatePuzzle(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider co)
    {

        player = co.GetComponent<Rigidbody>();
        if (player)
        {
            puzzleButs[0].Select();
            player.constraints = RigidbodyConstraints.FreezeAll;
            ActivatePuzzle(true);
        }
    }
    public void ActivatePuzzle(bool activate)
    {
        puzzleScreen.enabled = activate;
        for(int i = 0; i < puzzleButs.Length; i++)
        {
            puzzleButs[i].interactable = activate;
        }
    }
}
