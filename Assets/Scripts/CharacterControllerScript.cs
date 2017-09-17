using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour {

	public float speed = 1;
	public Rigidbody2D rb;

	Animator anim; 
	// variables for grounding
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = .2f;
	public LayerMask whatIsGround;

	public float jumpForce = 700;


	// Use this for initialization
	void Start () {
		//faceRight ();
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		rb.velocity = new Vector2 (speed, rb.velocity.y);

	}

	void Update () {
		// if we are grounded and pressing spacebar jump and say no longer grounded
		if (grounded && Input.GetKeyDown (KeyCode.Space)) {
			anim.SetBool ("Ground", false);
			rb.AddForce (new Vector2 (0, jumpForce));
		}


		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			Flip ();
		}

	}
	/*
	void faceRight () {
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
	}
	*/
	void Flip () {
		Vector3 scale = transform.localScale;
		scale.y *= -1;
		Physics2D.gravity *= -1;
		jumpForce *= -1;
		transform.localScale = scale;

	}
}
