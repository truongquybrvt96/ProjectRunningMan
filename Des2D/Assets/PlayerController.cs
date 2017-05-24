using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	/*WARNING: when you change value variable in code, It won't change in the game that's why you need to change directly
	in components ! PugPug*/ /*cam mom*/
	private Rigidbody2D r2;
	private Animator anim;

	public float speed = 300f;
	public float jumpPower = 150f;

	//Ground checking
	public Transform groundCheckTrans;
	public float groundCheckRadius = 0.1f;
	public LayerMask groundLayer;
	private bool grounded;

	// Use this for initialization
	void Start () {
		r2 = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
		
	void Update()
	{
		if (GameController.game.started) {
			if (Input.GetKeyDown (KeyCode.Space) && grounded) {
				r2.AddForce (Vector2.up*jumpPower);
				Debug.Log ("keke");
			}
		}
	}

	void FixedUpdate () {

		grounded = Physics2D.OverlapCircle (groundCheckTrans.position, groundCheckRadius, groundLayer );
		Debug.Log (grounded);
		anim.SetBool ("Grounded", grounded);
		if (GameController.game.started) {
			anim.SetTrigger ("Run");
			r2.velocity = new Vector2(speed * Time.deltaTime, 0);
			Debug.Log (r2.velocity.y);

		}

	}






}
