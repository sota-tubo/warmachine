using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move_Enemy_Crash : MonoBehaviour {
	private GameObject Base;
	private NavMeshAgent agentbase;
	private bool damageon;
	private Animator animator;

	// Use this for initialization
	void Start () {
		Base = GameObject.FindGameObjectWithTag("Base");
		agentbase = GetComponent<NavMeshAgent>();
		damageon = true;
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		agentbase.destination = Base.transform.position;
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player")
		{
			animator.SetBool("is_attack", true);
			if (damageon == true)
			{
				damageon = false;
				Player_Status.playerhp -= 10;
				Invoke("nodamage", 1f);
			}
		}
	}

	void nodamage()
	{
		damageon = true;
	}

	private void OnTriggerExit(Collider other)
	{
		animator.SetBool("is_attack", false);
	}
}
