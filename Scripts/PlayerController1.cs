using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {
	private Transform verRot;
	private Transform horRot;
	public int speed = 1;
	// Use this for initialization
	void Start () {
        verRot = transform.parent;
        horRot = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
		if (Input.GetMouseButton(1))
		{
			verRot.transform.Rotate(0, speed * X_Rotation, 0);
			horRot.transform.Rotate(speed * -Y_Rotation, 0, 0);
		}
	}
}
