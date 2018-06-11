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
    public bool diffused = false;
    bool logged;
    [SerializeField]
    Text LogField;

    // Use this for initialization
    void Start () {
        text = GetComponentInChildren<Text>();
        seconds = 60;
        minutes = 19;
        activated = false;
    }
	
	// Update is called once per frame
	void Update () {
        spotted = GetComponent<SayHello>().spotted;
        text.text = minutes.ToString() + ":" + Mathf.FloorToInt(seconds).ToString();
        if (spotted == true && diffused == false)
        {
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
			else if(seconds <= 0 && minutes % 5 == 0)
			{
				GameObject.Find ("NotificationBar").GetComponent<Notifications> ().GiveHint (0);
			}
            else if(minutes == 0)
            {
                Debug.Log("BOOM!");
            }
        }
	}
}
