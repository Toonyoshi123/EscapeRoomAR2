using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Notifications : MonoBehaviour {

	public int currentHintProgress = 0;
	public int currentUpdateProgress = 0;
	string[] hints = { };
	string[] updates = { };

	public Sprite[] apps = { };
	public Text text;
	public Image image;

	public void GiveHint(int app)
	{
		string hint = hints [currentHintProgress];
		//changing text and image of APP
		text.text = hint;
		image.sprite = apps [app];
		//play animation
		this.GetComponent<Animator>().Play("NotificationGoingDown");
	}

	public void AppUpdate(string update, int app)
	{
		// change text and image of App
		text.text = update;
		image.sprite = apps [app];
		//play animation
		this.GetComponent<Animator>().Play("NotificationGoingDown");
	}
}
