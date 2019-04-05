using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour {
    //this code ends the game's timer and possible death in the story.

    bool spotted;
	bool notified = false;
    [SerializeField]
    GameObject timer;
	
	// Update is called once per frame
	void Update () {
        spotted = GetComponent<SayHello>().spotted;
		if (spotted && !notified)
        {
            //turn off timer
            timer.GetComponent<Timer>().diffused = true;
			GameObject.Find ("NotificationSlider").GetComponent<Notifications> ().AppUpdate ("To disarm, put phone in hatch!",2);
			notified = true;
        }
    }
}
