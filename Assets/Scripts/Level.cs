using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Level{

    public bool treasure;
    public bool locked;
    public bool complete;

    public Level()
    {
        treasure = false;
        locked = true;
        complete = false;
    }
    public Level(bool locked)
    {
        this.locked = locked;
    }

    public bool GetLock()
    {
        return locked;
    }
    public bool GetTreasure()
    {
        return treasure;
    }
    public bool GetComplete()
    {
        return complete;
    }
}
