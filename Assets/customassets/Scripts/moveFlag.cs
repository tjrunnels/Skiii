using UnityEngine;
using System.Collections;


public class moveFlag : MonoBehaviour {

	float speed;
	public float top;
	public float bottom;
	//Vector3 moveSpeed = new Vector3 (0.0f, speed, 0f);
	bool iCanMove;


	// Update is called once per frame
	void Update () {
		speed = GlobalVariables.speed;
		iCanMove = GlobalVariables.canMove;

		if (iCanMove) {
			transform.Translate (Vector3.up * speed);
		}

		if (transform.position.y > top) {
			Debug.Log ("rip");
			GlobalVariables.flagCount--;
			Destroy (gameObject);
		}

	}
}