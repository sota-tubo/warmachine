using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Player : MonoBehaviour {
	public float speed = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		float mz = Input.GetAxis("Vertical");
		float mx = Input.GetAxis("Horizontal");
		transform.Translate(mx * speed * Time.deltaTime, 0, mz * speed * Time.deltaTime);
	}
}
