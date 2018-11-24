using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GargoyleParty : MonoBehaviour {

    public GameObject eddy;
    public GameObject freddy;
    public GameObject wendy;
    public GameObject roddy;

    private Profile profile;
	// Use this for initialization
	void Start () {
        CheckGargoyles();
	}
	
    public void CheckGargoyles()
    {
        profile = SaveLoad.LoadProfile();
        if (profile.levelOne.GetTreasure() == false)
        {
            Destroy(eddy);
            if (roddy)
                Destroy(roddy);
        }
        if (profile.levelTwo.GetTreasure() == false)
        {
            Destroy(freddy);
            if (roddy)
                Destroy(roddy);
        }
        if (profile.levelThree.GetTreasure() == false)
        {
            Destroy(wendy);
            if (roddy)
                Destroy(roddy);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
