using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDeathScreen : MonoBehaviour {



	// Update is called once per frame
	void Update () {
		if (GlobalVariables.deathCanMove) {
			this.gameObject.GetComponent<RectTransform> ().Translate (Vector3.up * 0.2f * (Time.deltaTime / (1.0f / 60.0f)));
		}

		if (this.gameObject.GetComponent<RectTransform> ().position.y >= 0) {
			GlobalVariables.deathCanMove = false;
		}

	}

}
