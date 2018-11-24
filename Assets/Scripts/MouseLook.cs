using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

    public float mouseSens = 100.0f;
    public float clampAngle = 80.0f;

    private float rotY = 0.0f; //https://answers.unity.com/questions/29741/mouse-look-script.html
    private float rotX = 0.0f;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
	}
	
	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotY += mouseX * mouseSens * Time.deltaTime;
        rotX += mouseY * mouseSens * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;
	}
}
