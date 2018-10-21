using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move_anim : MonoBehaviour {

    private Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("is_move", true);
        }
        else
        {
            animator.SetBool("is_move", false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("is_shot", true);
        }
        else
        {
            animator.SetBool("is_shot", false);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetBool("is_reroad", true);
        }
        else
        {
            animator.SetBool("is_reroad", false);
        }


        if (Input.GetKeyDown(KeyCode.M))
        {
            animator.SetBool("is_make", true);
        }
        else
        {
            animator.SetBool("is_make", false);
        }
    }
}
