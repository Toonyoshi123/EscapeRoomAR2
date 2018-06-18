using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChatRoom : MonoBehaviour {

	public GameObject chat;

	float currentposition = 837f;
	Text chatMessage;

	//create a new line of text in the contents gameObject, set this as their parent and give it all a set size and location compared to each other.
	public void NewLine(string line, int lines)
	{
		GameObject newChat = Instantiate (chat);
		//create the text and it's image
		chatMessage = newChat.GetComponentInChildren<Text>();
			
		chatMessage.GetComponent<Text>().text = line;
		chatMessage.GetComponent<Text>().fontSize = 55;
		chatMessage.GetComponent<RectTransform>().sizeDelta = new Vector2(585f, (lines * 60f));

		//set the size and position(319.4f, (currentposition - (lines * 60f) - 10f),0f)
		newChat.gameObject.GetComponent<RectTransform> ().transform.Translate(400f,(currentposition - (lines * 60f) - 10f),0f);
		newChat.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (595f,lines * 60f);

		newChat.transform.SetParent (this.transform);
		//update the position for the next message
		currentposition -= (lines * 60f) + 30f;

	}
}
