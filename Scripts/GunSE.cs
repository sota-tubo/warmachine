using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSE : MonoBehaviour {

    public AudioSource SE;
    public AudioClip S,R;
    float TimeCount = 1;

    void Start()
    {
        SE = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            SE.PlayOneShot(S);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SE.PlayOneShot(R);
        }
	}
}
