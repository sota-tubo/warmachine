using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulCol : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			Player_Status.playerhp -= 5;
			Destroy(gameObject);
		}
		if (collision.gameObject.tag == "Base")
		{
			Base_Status.basehp -= 5;
			Destroy(gameObject);
		}
		else if(collision.gameObject.tag == "PlayerBullet" ||
		        collision.gameObject.tag == "PlayerBullet2" ||
		        collision.gameObject.tag == "PlayerBullet3" ||
		        collision.gameObject.tag == "MobBullet" ||
		        collision.gameObject.tag == "EnemyBullet")
		{
			Destroy(gameObject);
		}
	}
}
