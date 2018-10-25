using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClicks : MonoBehaviour {

	public AudioSource clickNoise;

	public void OnClicked ()
	{
		if (!GlobalVariables.SFXMute)
			clickNoise.Play ();
	}
}
