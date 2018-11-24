using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteProfile : MonoBehaviour {
    public GameObject reloadLoad;
    private ShowLoadMenu showLoad;
   
    void Start()
    {
        showLoad = reloadLoad.GetComponent<ShowLoadMenu>();
    }
    public void DeleteConfirm()
    {

        //Add confirmation to delete for assignment 2
        SaveLoad.DeleteProfile();
        showLoad.ShowMenu();
    }
}
