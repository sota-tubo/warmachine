using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move_Enemy : MonoBehaviour {
	public GameObject Enebul;
	private Transform Enefirepos;
	private bool fireon = true;
	private bool baseon = false;
	private GameObject target, target2;
	private NavMeshAgent agent;
	public  static int EC = 2; //Wave.EFPCountと同値
	public static int[] ENum = new int[100];
	private Animator animator;

	// Use this for initialization
	void Start () {
		//子オブジェクトのtagを判別する
		for (int i = 0; i < EC; i++)
		{
			string efpst = "EFP" + ENum[i];
			if (this.gameObject.transform.GetChild(0).tag == efpst)
			{
				Enefirepos = GameObject.FindGameObjectWithTag(this.gameObject.transform.GetChild(0).tag)
									   .transform;
			}
		}
		target = GameObject.FindGameObjectWithTag("Player");
		target2 = GameObject.FindGameObjectWithTag("Base");
		agent = GetComponent<NavMeshAgent>();
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		//移動
		if (baseon == false)
		{
			agent.destination = target2.transform.position;
		}
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player")
		{
			baseon = true;
			animator.SetBool("is_attack", true);
			if (fireon == true)
			{
                fireon = false;
                StartCoroutine("EneShot");
				agent.destination = target.transform.position;
             }
		}
		else if (other.tag == "Base")
		{
			animator.SetBool("is_attack", true);
			if (fireon == true)
            {
                fireon = false;
                StartCoroutine("EneShot");
            }
		}
		else
		{
			animator.SetBool("is_attack", false);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		baseon = false;
	}

	private IEnumerator EneShot()
	{
		float Enebulspeed = 500f;
		//弾丸複製
		GameObject Enebullets  = GameObject.Instantiate(Enebul) as GameObject;

        Vector3 force;
		force = this.gameObject.transform.forward * Enebulspeed;
        //rigidbodyに力を加えて発射
		Enebullets.GetComponent<Rigidbody>().AddForce(force);
        //弾丸の位置調整
		Enebullets.transform.position = Enefirepos.position;
		Destroy(Enebullets, 2f);

		yield return new WaitForSeconds(1f);

		fireon = true;
	}
}
