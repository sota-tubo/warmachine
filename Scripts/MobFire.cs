using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobFire : MonoBehaviour {
	private Transform MobFirePos;
	public GameObject MobBul;
	private bool fireon;

	// Use this for initialization
	void Start () {
		fireon = true;
        /*
		var ChildTransForm = GameObject.Find(gameObject.name).transform;
		foreach (Transform child in ChildTransForm.transform)
		{
			if (child.tag == "MFP")
			{
				GameObject childObj = child.gameObject;
				MobFirePos = childObj.transform;
			}
		}
		*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "Gun" || other.tag == "Crash")
		{
			transform.LookAt(other.transform);
			if (fireon == true)
			{
				fireon = false;
				/*
				for (int i = 0; i < transform.childCount; i++)
                {
                    MobFirePos = transform.GetChild(i);
                }
                */
				MobFirePos = transform.GetChild(7);
				StartCoroutine("MobShot");
			}
		}
	}

	private IEnumerator MobShot()
	{
		/*
		var bullets = (GameObject)Instantiate(MobBul, MobFirePos.position,
		                                      MobFirePos.rotation);
		bullets.GetComponent<Rigidbody>().velocity = bullets.transform.forward * 6;
		*/
		float Mobbulspeed = 500f;
        //弾丸複製
		GameObject Mobbullets = GameObject.Instantiate(MobBul) as GameObject;

        Vector3 force;
        force = this.gameObject.transform.forward * Mobbulspeed;
        //rigidbodyに力を加えて発射
        Mobbullets.GetComponent<Rigidbody>().AddForce(force);
        //弾丸の位置調整
		Mobbullets.transform.position = MobFirePos.position;
		Destroy(Mobbullets, 2.5f);

		yield return new WaitForSeconds(1f);

		fireon = true;
	}
}
