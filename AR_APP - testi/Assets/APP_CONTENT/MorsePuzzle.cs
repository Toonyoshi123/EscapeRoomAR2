using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MorsePuzzle : MonoBehaviour {

    bool spotted;
    AudioSource source;
    bool logged;
    [SerializeField]
    Text LogField;

	public GameObject[] AudioFiles;

	// Use this for initialization
	void Start () {
        source = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        spotted = this.GetComponent<SayHello>().spotted;
		if(spotted == true && source.isPlaying == false)
        {
			GameObject.Find ("NotificationSlider").GetComponent<Notifications> ().AppUpdate ("An unknown file is being played!",4);
            source.Play();
			Invoke ("ImportFiles", 20f);
        }
        if (spotted == true && logged == false)
        {
            LogField.text = "morse kuve";
            logged = true;
        }
    }

	void ImportFiles()
	{
		foreach(GameObject audioFile in AudioFiles)
		{
			audioFile.SetActive (true);
			GameObject.Find ("NotificationSlider").GetComponent<Notifications> ().AppUpdate ("4 files have been added!",4);
		}
	}
}
