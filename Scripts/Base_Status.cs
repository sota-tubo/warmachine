using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Base_Status : MonoBehaviour {
	public static int basehp;

	// Use this for initialization
	void Start () {
		basehp = 500;
	}
	
	// Update is called once per frame
	void Update () {
		if (basehp <= 0)
		{
			SceneManager.LoadScene("Result");
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Crash")
		{
			basehp -= 100;
		}
	}
}
