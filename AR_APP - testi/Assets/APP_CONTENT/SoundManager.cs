using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	[SerializeField]
	AudioSource thisSource;

	[SerializeField]
	AudioSource otherSource1;
	[SerializeField]
	AudioSource otherSource2;
	[SerializeField]
	AudioSource otherSource3;

	public Sprite pauseButton;
	public Sprite playButton;

	public string fileName;
	public string fileNamePlaying;

	public void CheckSituation()
	{
		if (thisSource.isPlaying) {
			PauseSound ();
		} else {
			PlaySound ();
		}
	}

	public void PlaySound()
	{
		if(!otherSource1.isPlaying && !otherSource2.isPlaying && !otherSource3.isPlaying)
		{
			thisSource.Play ();
			//change image
			this.GetComponent<Image>().sprite = pauseButton;
			this.GetComponentInChildren<Text> ().text = fileNamePlaying;
		}
	}

	public void PauseSound()
	{
		thisSource.Pause ();
		//change image
		this.GetComponent<Image>().sprite = playButton;
		this.GetComponentInChildren<Text> ().text = fileName;
	}

	void Update()
	{
		if(!thisSource.isPlaying)
		{
			this.GetComponent<Image>().sprite = playButton;
			this.GetComponentInChildren<Text> ().text = fileName;
		}
	}
}
