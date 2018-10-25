using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreenController : MonoBehaviour {
	AudioSource theme;
	public AudioSource clickNoise;

	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 60;
		theme = this.gameObject.GetComponent<AudioSource>();
		DontDestroyOnLoad (this.gameObject);



		if (!GlobalVariables.musicPlaying) {
			Debug.Log ("Music Start");
			theme.Play ();
			GlobalVariables.musicPlaying = true;
		}
			
	}

	void Update()
	{
		if (GlobalVariables.musicMute == true && theme.mute == false)
		{
			Debug.Log ("mute");
			theme.mute = true;
		}

		if (GlobalVariables.musicMute == false && theme.mute == true)
		{
			Debug.Log("unm");
			theme.mute = false;
		}
			
	}

	public void OnClicked ()
	{
		if (!GlobalVariables.SFXMute)
		clickNoise.Play ();
	}

}
