using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

    Text text;
    public float seconds;
    public float minutes;
    public bool activated;
    bool spotted = false;
	bool notified = false;
    public bool diffused = false;
    bool logged;
    [SerializeField]
    Text LogField;

	int hintNumber;

	public GameObject arctic;
	public GameObject system;

    // Use this for initialization
    void Start () {
        text = GetComponentInChildren<Text>();
        seconds = 60;
        minutes = 24;
        activated = false;
    }
	
	// Update is called once per frame
	void Update () {
        spotted = GetComponent<SayHello>().spotted;
        text.text = minutes.ToString() + ":" + Mathf.FloorToInt(seconds).ToString();
		if (spotted == true && diffused == false && activated == false)
        {
			if(!notified){
				GameObject.Find ("NotificationSlider").GetComponent<Notifications> ().AppUpdate ("You got a message from arctic-fox!",2);
				notified = true;
				arctic.GetComponent<ChatRoom> ().NewLine ("The countdown has been started. While I can’t tell you how to solve it (in the case this phone finds its way into the wrong hands) I can help you. There are more markers on the boxes that give hints towards solving the riddles ahead. The first key I can give you is this:\n. = 1\n- = 2\nI’m counting on you. Good luck.\n",17f, false);
				system.GetComponent<ChatRoom> ().NewLine ("Triangle", 1f, true);
			}
			activated = true;
        }

        if (spotted == true && logged == false)
        {
            LogField.text = "timer kuve";
            logged = true;
        }

        if (activated == true && diffused == false)
        {
            seconds -= Time.deltaTime;
            if(seconds <= 0 && minutes > 0)
            {
                seconds = 60;
                minutes--;
            }
			else if(seconds <= 0 && ((minutes + 1) % 2) == 0)
			{
				GameObject.Find ("NotificationBar").GetComponent<Notifications> ().GiveHint (0);
				hintNumber++;
			}
			else if(minutes == 0 && seconds <= 0)
            {
				GameObject.Find ("NotificationSlider").GetComponent<Notifications> ().AppUpdate ("BOOM!",2);
            }
        }
	}
}
