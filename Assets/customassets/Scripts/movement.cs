using UnityEngine;
using System.Collections;


public class movement : MonoBehaviour {


	bool startMove = true;
	float speed;
	public float lrspeed;
	public int lrspeedUpgrade;
	int lane = 2;
	Rigidbody2D rb;
	bool canTele = true;
	Vector2 tempPos;
	int width;
	bool canTouch;
	bool canmove; 

	public AudioSource turnSound;

	public Sprite straight;
	public Sprite left;
	public Sprite right;
	public SpriteRenderer spriter;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		width = Screen.width;
		lrspeed = lrspeed + GlobalVariables.speed * lrspeedUpgrade;
	}

	bool inRange (float x, float a)
	{
		if (x > (a - 0.3)) {
			if (x < (a + 0.3)) {
				return true;
			}
		} 
			return false;
	}


	// Update is called once per frame
	void Update () {
		speed = GlobalVariables.speed;

		//opening animation
		if (startMove) {
			transform.Translate (Vector3.down * speed);
			if (transform.position.y < 2.0f) {
				startMove = false;
				GlobalVariables.canMove = true;
			}
		}
			


		//player input and move left and right
		tempPos = new Vector2(transform.position.x, transform.position.y);

		if (inRange (transform.position.x, -1.75f)  && lane != 1) {
			rb.velocity = Vector2.zero;
			lane = 1;
			spriter.sprite = straight;
		}
		if (inRange (transform.position.x, 0f) && lane != 2) {
			rb.velocity = Vector2.zero;
			lane = 2;
			spriter.sprite = straight;
		}
		if (inRange (transform.position.x, 1.75f) && lane != 3) {
			rb.velocity = Vector2.zero;
			lane = 3;
			spriter.sprite = straight;
		}
			
		if (inRange (transform.position.x, 3.2f) && canTele) {
			transform.position = new Vector2 (-3.1f, tempPos.y);
			canTele = false;
		}
		if (inRange (transform.position.x, -3.2f) && canTele) {
			transform.position = new Vector2 (3.1f, tempPos.y);
			canTele = false;
		}




		if (Input.inputString != "")
			canTele = true;

		if (Input.touchCount == 0) {
			canTouch = true;
			canTele = true;
		}



		canmove = GlobalVariables.canMove;

		if (!canmove) {
			rb.velocity = Vector2.zero;
		}


		if (canmove && ((canTouch && Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began  && Input.GetTouch (0).position.x > (width/2)) || Input.GetKeyDown(KeyCode.D)) ) {
				Debug.Log ("right");
				rb.velocity = (Vector2.right * lrspeed);
				canTouch = false;

			if(!GlobalVariables.SFXMute)
				turnSound.Play ();

			spriter.sprite = right;
		}
		 
		if (canmove && ((canTouch && Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began  && Input.GetTouch (0).position.x < (width/2)) || Input.GetKeyDown(KeyCode.A)) ) {
				Debug.Log ("left");
				rb.velocity = (Vector2.left * lrspeed);
				canTouch = false;
				
			if(!GlobalVariables.SFXMute)
				turnSound.Play ();

			spriter.sprite = left;
		//	this.gameObject.GetComponent<SpriteRenderer> ().sprite = (Sprite)left;
			}
				




		//saved code

//
//		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began  && Input.GetTouch (0).position.x < (width/2)) {
//			Debug.Log ("Left");
//		}
//		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began  && Input.GetTouch (0).position.x > (width/2)) {
//			Debug.Log ("Right");
//		}
	
//		if (tempScore != GlobalVariables.score)
//			Debug.Log ("Score: " + GlobalVariables.score);
//
//		tempScore = GlobalVariables.score;

	}
}