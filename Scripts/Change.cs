using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;

    GameObject Player;
    GameObject P1;

    int cou;

    // Use this for initialization
    void Start() {
        Player = GameObject.Find("Player");

        Vector3 pos = GameObject.Find("Player").transform.position;
        P1 = Instantiate(Player1, pos, Quaternion.identity);
        P1.transform.parent = Player.transform;
		cou = 0;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.C))
        {

            cou++;
            switch (cou) {
                case 1:
                    Vector3 pos2 = GameObject.Find("Player").transform.position;
                    Quaternion rot2 = GameObject.Find("Player").transform.rotation;
                    P1 = Instantiate(Player2, pos2, rot2);
                    P1.transform.parent = Player.transform;
                    Destroy(GameObject.Find("Player1(Clone)"));
                    break;
                case 2:
                    Vector3 pos3 = GameObject.Find("Player").transform.position;
                    Quaternion rot3 = GameObject.Find("Player").transform.rotation;
                    P1 = Instantiate(Player3, pos3, rot3);
                    P1.transform.parent = Player.transform;
                    Destroy(GameObject.Find("Player2(Clone)"));
                    break;
                default:
                    Vector3 pos1 = GameObject.Find("Player").transform.position;
                    Quaternion rot1 = GameObject.Find("Player").transform.rotation;
                    P1 = Instantiate(Player1, pos1, rot1);
                    P1.transform.parent = Player.transform;
                    Destroy(GameObject.Find("Player3(Clone)"));
                    cou = 0;
                    break;

            }

        }
    }
}
