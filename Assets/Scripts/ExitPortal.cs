using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitPortal : MonoBehaviour {



    private TreasureUI treasure;
    private Profile profile;


    void Start()
    {

    }

    void OnTriggerEnter(Collider co)
    {
        if (co.GetComponentInChildren<Health>())
        {
            profile = SaveLoad.LoadProfile();
            if (SceneManager.GetActiveScene().name == "Level1")
            {
                treasure = co.GetComponentInChildren<TreasureUI>();
                if (treasure)
                {
                    if (treasure.haveTreasure == true)
                        profile.levelOne.treasure = true;
                }
                profile.levelOne.complete = true;
                profile.levelTwo.locked = false;
                SaveLoad.Save(profile);
                SceneManager.LoadScene("Level2");
            }
            if (SceneManager.GetActiveScene().name == "Level2")
            {
                treasure = co.GetComponentInChildren<TreasureUI>();
                if (treasure)
                {
                    if (treasure.haveTreasure == true)
                        profile.levelTwo.treasure = true;
                }
                profile.levelTwo.complete = true;
                profile.levelThree.locked = false;
                SaveLoad.Save(profile);
                SceneManager.LoadScene("Intermission");
            }
            if(SceneManager.GetActiveScene().name == "Intermission")
            {
                SceneManager.LoadScene("Level3");
            }
            if(SceneManager.GetActiveScene().name == "Level3")
            {
                treasure = co.GetComponentInChildren<TreasureUI>();
                if (treasure)
                {
                    if (treasure.haveTreasure == true)
                        profile.levelThree.treasure = true;
                }
                profile.levelThree.complete = true;
                SaveLoad.Save(profile);
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
