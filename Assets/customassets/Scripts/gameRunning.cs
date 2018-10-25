using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameRunning : MonoBehaviour {

	public float speedUp;
	private int tempScore = 0;
	private float startSpeed;

	AudioSource LoopingSki;
	public AudioSource score;
	public AudioSource XScore;

	void Start () {
		GlobalVariables.flagCount = 0;
		GlobalVariables.score = 0;
		GlobalVariables.speed = 0.09f;
		startSpeed = GlobalVariables.speed;
		LoopingSki = this.gameObject.GetComponent<AudioSource> ();


		if (!GlobalVariables.SFXMute) {
			LoopingSki.Play ();
		}
	}

	// Update is called once per frame
	void Update () {

		if (!GlobalVariables.SFXMute) {
			if (tempScore < GlobalVariables.score) {
				if (GlobalVariables.score % 10 == 0)
					XScore.Play ();
				else
					score.Play ();
			}

		}
		tempScore = GlobalVariables.score;

			

		//speed up script
		GlobalVariables.speed = ((tempScore * speedUp) + startSpeed) * (Time.deltaTime / (1.0f / 60.0f));


		if (GlobalVariables.deathCanMove) {
			LoopingSki.mute = true;
		}

	}
}
