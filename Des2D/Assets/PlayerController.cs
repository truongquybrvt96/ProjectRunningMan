using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	/*WARNING: when you change value variable in code, It won't change in the game that's why you need to change directly
	in components ! PugPug*/ /*cam mom*/
	private Rigidbody2D r2;
	private Animator anim;

	public float speed = 1f;
	public float jumpPower = 150f;

	//Ground checking
	public Transform groundCheckTrans;
	public float groundCheckRadius = 1f;
	public LayerMask groundPlayer;
	private bool grounded;

	// Use this for initialization
	void Start () {
		r2 = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
		
	// Update is called once per frame
	void FixedUpdate () {

		grounded = Physics2D.OverlapCircle (groundCheckTrans.position, groundCheckRadius, groundPlayer );

		if (GameController.game.started) {
			anim.SetTrigger ("Run");
			if (grounded) {
				Debug.Log ("Grounded");
			}
			else
				Debug.Log ("Grounded false");
			if (Input.GetKeyDown (KeyCode.Space) && grounded) {
				
				r2.AddForce (new Vector2(0, jumpPower));
			}
			//r2.AddForce (new Vector2(speed, curJumpP));
			r2.velocity = new Vector2(speed * Time.deltaTime, r2.velocity.y);


		}
	}






}
