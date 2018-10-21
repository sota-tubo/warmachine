using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour {

    private Transform verRot;
    private Transform horRot;

    GameObject PlayerObj;
    Vector3 PlayerPos;

    void Start()
    {
        PlayerObj = GameObject.Find("Player");
        PlayerPos = PlayerObj.transform.position;

        verRot = transform.parent;
        horRot = GetComponent<Transform>();
    }

    void Update()
    {
        PlayerPos = PlayerObj.transform.position;

        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        if (Input.GetMouseButton(1))
        {
            verRot.transform.Rotate(0, 5 * X_Rotation, 0);
            horRot.transform.Rotate(5 * -Y_Rotation, 0, 0);
        }
    }
}
