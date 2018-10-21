using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move_GunEnemy : MonoBehaviour {
    private bool baseon = false;
    private GameObject target, target2;
    private NavMeshAgent agent;
    private Animator animator;

    // Use this for initialization
    void Start()
	{
        target = GameObject.FindGameObjectWithTag("Player");
        target2 = GameObject.FindGameObjectWithTag("Base");
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
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

			agent.destination = target.transform.position;
        }
        else if (other.tag == "Base")
        {
            animator.SetBool("is_attack", true);
			agent.destination = target2.transform.position;
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
}
