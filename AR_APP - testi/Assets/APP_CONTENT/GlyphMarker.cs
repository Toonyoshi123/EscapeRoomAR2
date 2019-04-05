using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlyphMarker : MonoBehaviour {
    //This code activates the glyph-text puzzle. Adding the translator to the notes section.

	bool spotted = false;
	bool notified = false;
	public GameObject phoenix;
	// Update is called once per frame
	void Update () {
		spotted = GetComponent<SayHello>().spotted;

		if(spotted == true && !notified)
		{
			GameObject.Find ("NotificationSlider").GetComponent<Notifications> ().AppUpdate ("You got a message from phoenix!", 2);
			phoenix.GetComponentInChildren<ChatRoom> ().NewLine ("Good day Engineer,\n These logs are provided for your convenience. Work quickly and help Phoenix engage.\n Please look at your notes.",6f,false);

			notified = true;
		}
	}
}
