using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Profile {

    public static Profile profile;
    public Level levelOne;
    public Level levelTwo;
    public Level levelThree;
    public bool firstGame;

    public Profile()
    {
        levelOne = new Level();
        levelTwo = new Level();
        levelThree = new Level();
        firstGame = true;
    }

}
