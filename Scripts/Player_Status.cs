using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Status : MonoBehaviour {
	public static int playerhp;

	// Use this for initialization
	void Start () {
		playerhp = 100;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (playerhp <= 0)
		{
			SceneManager.LoadScene("Result");
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		
	}
}
