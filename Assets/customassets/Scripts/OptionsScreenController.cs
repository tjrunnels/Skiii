using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsScreenController : MonoBehaviour {



	public Sprite mute;
	public Sprite normal;

	public Image music;
	public Image sfx;

	void Start()
	{
		if (GlobalVariables.musicMute)
			music.sprite = mute;
		else
			music.sprite = normal;

		if (GlobalVariables.SFXMute)
			sfx.sprite = mute;
		else
			sfx.sprite = normal;
		

	}

	public void ToggleMusic()
	{
		GlobalVariables.musicMute = !(GlobalVariables.musicMute);

		if (GlobalVariables.musicMute)
			music.sprite = mute;
		else
			music.sprite = normal;
		
		variables.Save ();
	}

	public void ToggleSFX()
	{
		GlobalVariables.SFXMute = !(GlobalVariables.SFXMute);

		if (GlobalVariables.SFXMute)
			sfx.sprite = mute;
		else
			sfx.sprite = normal;

		variables.Save ();
	}
		
}