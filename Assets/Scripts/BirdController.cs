using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BirdController : MonoBehaviour {

	public GameObject the_aliveworm;
	public GameObject the_deadworm;
	public float rightForce;	// initialize to 4f from the Inspector;
	public float upForce;  		// initialize to 3f from the Inspector;
	private float directionControl = 1f;		// initialized to 1f here
	// private Animator anim;
	// public float maxSpeed = 10f;

	void Awake () {		// added for animating the bird
		//anim = GetComponent<Animator> ();
	}
	
	void Update () {

///*
		// get the arrow keypresses from the keyboard and move the bird by translation
		// no Rigidbody2D needed
		// preferred method when wanting to control the bird with the the arrow keys!

		if (Input.GetKey ("right")) {
			Flip ("right");		// Added, lesson 8
			transform.Translate (.1f, 0f, 0f);
		}
		if (Input.GetKey ("left")) {
			Flip ("left");	// Added, lesson 8
			transform.Translate (-.1f, 0f, 0f);
		}
		if (Input.GetKey ("up")) {
			transform.Translate (0f, .1f, 0f);
		}
		if (Input.GetKey ("down")) {
			transform.Translate (0f, -.1f, 0f);
		}

//*/
///*
		// The code below will perform the following actions:
		
		// - Respond to left-button mouse clicks
		// - Move the Bird with Physics forces when a click occurs
		// - Change the Bird’s direction of movement automatically
				
		// use this code first when moving the bird with mouse clicks and physics
		// (later, replace it with the preferred code below this one)
		// when the left mouse button is clicked, the bird is moved by AddForce
		// use gravity set to .001 (or 0) when applying force only in the X direction
		// use gravity set to about .2 when applying force in both the X and Y direction 

		if (Input.GetMouseButtonDown (0)) {	// if the left mouse button was clicked...
			Debug.Log("The left mouse button was clicked");
		//	GetComponent<Rigidbody2D> ().AddForce (Vector2.right, ForceMode2D.Impulse);		// initially, set gravity = .001
		//	GetComponent<Rigidbody2D> ().AddForce (Vector2.right * directionControl, ForceMode2D.Impulse);		
		//	GetComponent<Rigidbody2D> ().AddForce (Vector2.up, ForceMode2D.Impulse);		// use with gravity = .2
		}
//*/


		// this is the preferred code when controlling the bird with the mouse!
		// gets the left mousedown button click and moves the bird by AddForce
		// requires a a Rigidbody2D component on the Bird (gravity set to non-zero) (.8 seems to work well)
/*
		if (Input.GetMouseButtonDown (0)) {	
			GetComponent<Rigidbody2D> ().velocity = Vector2.zero;		// used to smooth the Impulse force
			GetComponent<Rigidbody2D> ().AddForce (Vector2.right * rightForce * directionControl, ForceMode2D.Impulse);		
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * upForce, ForceMode2D.Impulse);

			//  anim = GetComponent<Animator> ();	// this was done in the Awake() method, but optionally repeated here for brevity
			//  anim.SetTrigger ("flytrigger");	// set the parameter for the idle -> fly transition to occur
		}
*/
	}
	
	void OnCollisionEnter2D(Collision2D what_the_bird_hit) {

		if (what_the_bird_hit.gameObject.name == "theworm") {	
			
			Debug.Log ("The Bird got the Worm");
			the_aliveworm.SetActive(false);
			the_deadworm.SetActive(true);
/*
			Flip ("left");			// use only when Bird is moved with the mouse click (physics)
			directionControl = -1;		// use when Bird is moved with the mouse click (physics)
*/
		}	

		if (what_the_bird_hit.gameObject.name == "launchtree") {

			Debug.Log ("The Bird reached the Nest");
			the_aliveworm.SetActive(true);
			the_deadworm.SetActive(false);

			GetComponent<Rigidbody2D> ().velocity = Vector2.zero;		// this completely stops the Bird's movement
											// needed for Unity v 5.3.3 and above

/*
			Flip ("right");			// use only when Bird is moved with the mouse click (physics)
			directionControl = 1;		// use when Bird is moved with the mouse click (physics)
		//	IncrementScore();
*/
		}	
	}

	public void Flip(string direction) {	// Added, lesson 8.
		var thescale = transform.localScale;	// X Scale must be 1 or -1 for this to work properly
		if (direction == "right") {
			thescale.x = 1.0f;		//  flip it to the right, by making sure the x scale is positive
			//Debug.Log ("bird flipped right");

		}
		else {
			thescale.x = -1.0f;		//  flip it to the left, by making sure the x scale is negative
			//Debug.Log ("bird flipped left");

		}
		transform.localScale = thescale;	
	}
	
/*
	public void IncrementScore() {
		var theGameManager = GameObject.Find ("GameController").GetComponent<GameManager>();
		theGameManager.score = theGameManager.score + 1;
		theGameManager.txtScore.text  = "Score: " + theGameManager.score;

//		if (theGameManager.score == 3) {
//			theGameManager.txtScore.text = "You Win!!!";	// ref 2D Catch Game - Part 2, time: 38:38
//			theGameManager.btnRestart.gameObject.SetActive(true);
//		}
	}
*/

////////////////////////////////////            additional example code                 /////////////////////////////////
////////////////////////////////////     that can be testing in the Update() method      ////////////////////////////////
/*
		// get the left mousedown button click and move the bird by translation
		// no rigidbody or set gravity to 0
		// just a demo technique to show moving the bird using the translate property
		
		if (Input.GetMouseButtonDown (0)) {	
			Debug.Log ("GetMouseButtonDown  pressed");
			transform.Translate (1f, 0f, 0f);
		}
*/
/*
		// get the arrow keypresses from the keyboard and move the bird by velocity
		// the following requires a rigidbody (gravity set to zero)
		// just a demo technique to show moving the bird using the velocity property

		float movey = Input.GetAxis ("Vertical");
		float movex = Input.GetAxis ("Horizontal");
		// Debug.Log ("movex  = " + movex);

		if (Input.GetKey ("left") || Input.GetKey ("right") || Input.GetKey ("up") || Input.GetKey ("down")) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (movex * maxSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, movey * maxSpeed);
		}
		if (Input.GetKey ("space")) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, 0f);	// zero velocity stops the bird
		}
*/
/////////////////////////////////////////     end of additional example code     /////////////////////////////////////	

}
