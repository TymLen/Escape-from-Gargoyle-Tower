using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class FixFocus : MonoBehaviour {

    private GameObject selectedObj;
	void Update () {
		if(EventSystem.current.currentSelectedGameObject != null)
        {
                selectedObj = EventSystem.current.currentSelectedGameObject;
        }
        else if(EventSystem.current.currentSelectedGameObject == null)
        {
            if (selectedObj != null)
            {
                EventSystem.current.SetSelectedGameObject(selectedObj);
                selectedObj.GetComponent<Button>().onClick.Invoke();
            }
            
        }
	}
}
