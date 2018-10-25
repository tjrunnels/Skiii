using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSnow : MonoBehaviour {

	float speed;
	public float top;
	public float bottom;
	Vector3 bottomPos;
	//Vector3 moveSpeed = new Vector3 (0.0f, speed, 0f);
	bool iCanMove;


	void Start() {
		bottomPos = new Vector3 (0, bottom, 0);
	}
	// Update is called once per frame
	void Update () {
		speed = GlobalVariables.speed;
		iCanMove = GlobalVariables.canMove;

		if (iCanMove) {
			transform.Translate (Vector3.up * speed);
		}

		if (transform.position.y > top) {
			transform.position = bottomPos;
		}

	}

}
