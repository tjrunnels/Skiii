using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuSnow : MonoBehaviour {

	float speed = 0.06f;
	float adjustedSpeed;
	public float top;
	public float bottom;
	Vector3 bottomPos;
	bool iCanMove = true;



	void Start() {
		bottomPos = new Vector3 (0, bottom, 0);
	}

	void Update () {
		adjustedSpeed = speed * (Time.deltaTime / (1.0f / 60.0f));

		if (iCanMove) {
			transform.Translate (Vector3.up * adjustedSpeed);
		}

		if (transform.position.y > top) {
			transform.position = bottomPos;
		}

	}

}
