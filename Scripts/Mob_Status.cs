using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob_Status : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Gun" ||
		    collision.gameObject.tag == "Crash" ||
		    collision.gameObject.tag == "EnemyBullet")
		{
			Destroy(gameObject);
		}
	}
}
