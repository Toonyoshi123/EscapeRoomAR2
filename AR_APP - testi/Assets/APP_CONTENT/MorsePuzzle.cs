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

	// Use this for initialization
	void Start () {
        source = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        spotted = this.GetComponent<SayHello>().spotted;
        if(spotted == true && source.isPlaying == false)
        {
            source.Play();
        }
        if (spotted == true && logged == false)
        {
            LogField.text = "morse kuve";
            logged = true;
        }
    }
}
