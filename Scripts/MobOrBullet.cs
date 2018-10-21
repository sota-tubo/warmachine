using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobOrBullet : MonoBehaviour {
	public GameObject Mob;
	private Vector3 MP;
	private int mobcount;
	private bool MatCount;
	// Use this for initialization
	void Start () {
		MatCount = true;
		mobcount = 0;
		MP = new Vector3(0, 0, 3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.M) && MaterialCounter.MatCount > 0 && MatCount == true)
		{
			MatCount = false;
			MaterialCounter.MatCount--;
			mobcount++;
			Vector3 MobPos = this.gameObject.transform.position + MP;
			Instantiate(Mob, MobPos, Quaternion.Euler(0f,90f,0f));
			Invoke("maton", 0.5f);
		}
		else if (Input.GetKeyDown(KeyCode.N) && MaterialCounter.MatCount > 0 && MatCount == true)
		{
			MatCount = false;
			MaterialCounter.MatCount--;
			if (Fire.weaponchange == 0)
			{
				Fire.allbulcount += 6;
			}
			else if (Fire.weaponchange == 1)
			{
				Fire.allbulcount2 += 60;
			}
			else if (Fire.weaponchange == 2)
			{
				Fire.allbulcount3 += 3;
			}
			Invoke("maton", 0.5f);
		}
	}

	private void maton()
	{
		MatCount = true;
	}
}
