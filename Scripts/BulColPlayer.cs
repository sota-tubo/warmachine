using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulColPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Crash" ||
		    collision.gameObject.tag == "Gun" ||
		    collision.gameObject.tag == "EnemyBullet" ||
		    collision.gameObject.tag == "PlayerBullet" ||
            collision.gameObject.tag == "PlayerBullet2" ||
            collision.gameObject.tag == "PlayerBullet3" ||
		    collision.gameObject.tag == "MobBullet")
		{
			Destroy(gameObject);
		}
	}
}
