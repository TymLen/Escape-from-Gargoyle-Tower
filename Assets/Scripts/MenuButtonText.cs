using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuButtonText : MonoBehaviour, ISelectHandler, IDeselectHandler {

    // Use this for initialization
    
    public Color highColor = Color.red;

    private Color startColor;

    void Start()
    {
        startColor = GetComponentInChildren<Text>().color;
        if(startColor == Color.red)
        {
            startColor = Color.black;
        }
    }
    public void OnSelect(BaseEventData eventData)
    {
        GetComponentInChildren<Text>().color = highColor;
    }

    public void OnDeselect(BaseEventData eventData)
    {
        GetComponentInChildren<Text>().color = startColor;
    }
}
