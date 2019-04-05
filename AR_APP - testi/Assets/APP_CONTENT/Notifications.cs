using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Notifications : MonoBehaviour {
    //this code makes the notification bar come down with new information.

	string[] hints = {"The camera can be used to scan markers.", "The code can be put into the calculator.", "The recordings are in the right order.", "Each log has one correctly positioned disc.", "What did phoenix tell you about the glyph?", "North4, South3, West2, East1.", "You need to translate.", "Arctic gave you a nice hint.", "The colors match the apps."};

	public Sprite[] apps = { };
	public Text text;
	public Image image;

	public GameObject system;
	public GameObject arctic;

	void Awake () {
		arctic.GetComponentInChildren<ChatRoom> ().NewLine ("Dear me,\nI hope this message reaches you well. If my calculations are correct, the crisis should start on *insert date here*. There are two boxes before you, one sent by me and the other sent by… Well, me. While I wish I could explain the science behind timelines, we are ironically short on time.\nOne of the boxes contains Project Phoenix, a virus designed to wipe out 75% of humanity within an year of its release. The other one contains the cure required to stop it. However, since the cure could be used to reverse-engineer the virus, you are the only person I can trust with it.\nIn order to be able to stop Project Phoenix, you will have to set it off. Once you start the premature countdown, you will have 25 minutes to stop it from releasing. Scan the marker on the top of the box with the camera application in order to begin.\nI will keep in touch with you.",43f, false);
		GameObject.Find ("NotificationSlider").GetComponent<Notifications> ().AppUpdate ("You got a message from arctic-fox!",2);
	}

	public void GiveHint(int hintNumber)
	{
		string hint = hints [hintNumber];
		//changing text and image of APP
		text.text = hint;
		system.GetComponent<ChatRoom> ().NewLine (hint, 2,false);
		image.sprite = apps [2];
		//play animation
		this.GetComponent<Animator>().Play("NotificationGoingDown");
		this.GetComponent<AudioSource> ().Play ();
	}

	public void AppUpdate(string update, int app)
	{
		// change text and image of App
		text.text = update;
		system.GetComponent<ChatRoom> ().NewLine (update, 2,false);
		image.sprite = apps [app];
		//play animation
		this.GetComponent<Animator>().Play("NotificationGoingDown");
		this.GetComponent<AudioSource> ().Play ();
	}
}
