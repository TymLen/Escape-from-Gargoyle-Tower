using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public static class SaveLoad {

    public static Profile savedProfile;

    public static void Save(Profile inProfile)
    {
        SaveLoad.savedProfile = inProfile;
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/profile.gd");
        bf.Serialize(file, SaveLoad.savedProfile);
        file.Close();
    }

    public static Profile LoadProfile()
    {
        if(File.Exists(Application.persistentDataPath + "/profile.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/profile.gd", FileMode.Open);
            SaveLoad.savedProfile = (Profile)bf.Deserialize(file);
            file.Close();
        }
        if(!File.Exists(Application.persistentDataPath + "/profile.gd"))
        {
            SaveLoad.savedProfile = new Profile();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + "/profile.gd");
            bf.Serialize(file, SaveLoad.savedProfile);
            file.Close();
        }
        return SaveLoad.savedProfile;
    }

    public static void DeleteProfile()
    {
        SaveLoad.savedProfile = new Profile();
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/profile.gd");
        bf.Serialize(file, SaveLoad.savedProfile);
        file.Close();
    }

}


