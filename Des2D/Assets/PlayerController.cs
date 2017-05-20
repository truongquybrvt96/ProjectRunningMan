using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	/*WARNING: when you change value variable in code, It won't change in the game that's why you need to change directly
	in components ! PugPug*/
	private Rigidbody2D r2;
	bool isStart=false;
	private Animator anim;
	public float speedForce=250f;
	//----var fly------------
	private bool isFly=false;
	public float upForce=275f;
	private float timeFly=1f,timeCnt=0;//we must wait 1s for the next flight
	// Use this for initialization
	void Start () {
		r2 = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!isStart) {
			//we need to init for the first time and prepare to play the game
			if (Input.GetKeyDown (KeyCode.Space))
				isStart = true;
		} else {
			GameController.game.ClearStartText();//this function will clear the text in the middle of screen
			anim.SetTrigger ("Run");
			r2.AddForce (new Vector2 (speedForce, 0));//uses addforce to make velocity :v
			//--------Check condition to fly-------------
			if (!isFly && isStart) {
				if (Input.GetKeyDown (KeyCode.Space)) {
					r2.AddForce (new Vector2 (0, upForce));
					isFly = true;
				}

			} else {
				timeCnt += Time.deltaTime;
				if (timeCnt >= timeFly) {
					isFly = false;
					timeCnt = 0;
				}
			}
			//------------------------------------------
		}
	}






}
