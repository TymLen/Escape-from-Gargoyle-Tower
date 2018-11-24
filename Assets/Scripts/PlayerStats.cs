using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStats {

    private static int level2Attempts, level3Attempts;
    private static bool level2Check = false;

    public static int GetLevel2Attempts()
    {
        return level2Attempts;
    }
    public static int GetLevel3Attempts()
    {
        return level3Attempts;
    }
    public static void SetLevel2Attempts(int inDeath)
    {
        level2Attempts += inDeath;
    }
    public static void SetLevel3Attempts(int inDeath)
    {
        level3Attempts = inDeath;
    }
    public static void IncLevel2Death()
    {
        level2Attempts++;
    }
    public static void IncLevel3Death()
    {
        level3Attempts++;
    }
    public static bool Get2Check()
    {
        return level2Check;
    }
    public static void Set2Check(bool inCheck)
    {
        level2Check = inCheck;
    }
}
