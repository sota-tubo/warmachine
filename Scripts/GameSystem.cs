using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Player_Status.playerhp <= 0 || Base_Status.basehp <= 0)
		{
			SceneManager.LoadScene("Result");
		}
	}
}
