using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Status : MonoBehaviour {
	private int curhp;

	// Use this for initialization
	void Start () {
		curhp = Wave.enemyhp;
	}
	
	// Update is called once per frame
	void Update () {
		if (curhp <= 0)
		{
			Destroy(gameObject);
			Wave.enecount--;
			Vis_Score.score += 10;
			MaterialCounter.MatCount++;
        }
	}

	private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player_Status.playerhp -= 20;
            Destroy(gameObject);
			Wave.enecount--;
        }
        else if (collision.gameObject.tag == "PlayerBullet")
        {
			curhp -= 10;
        }
        else if (collision.gameObject.tag == "PlayerBullet2")
        {
			curhp -= 5;
        }
        else if (collision.gameObject.tag == "PlayerBullet3")
        {
			curhp -= 30;
        }
        else if (collision.gameObject.tag == "Base")
        {
            Destroy(gameObject);
			Wave.enecount--;
        }
		else if (collision.gameObject.tag == "MobBullet")
		{
			curhp -= 5;
		}
    }
}
