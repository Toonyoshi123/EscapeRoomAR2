using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChatRoom : MonoBehaviour {

	public GameObject chat;

	float currentposition = 0;
	Text chatMessage;
	public Font braile;

	//create a new line of text in the contents gameObject, set this as their parent and give it all a set size and location compared to each other.
	public void NewLine(string line, float lines, bool isBraile)
	{
		GameObject newChat = Instantiate (chat, this.transform);
		//create the text and it's image
		chatMessage = newChat.GetComponentInChildren<Text>();
			
		chatMessage.GetComponent<Text>().text = line;
		chatMessage.GetComponent<Text>().fontSize = 55;
		if(isBraile)
		{
			chatMessage.GetComponent<Text> ().font = braile;
		}
		chatMessage.GetComponent<RectTransform>().sizeDelta = new Vector2(this.GetComponent<RectTransform>().sizeDelta.x - 10f, (lines * 62f));

		//set the size and position
		newChat.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (this.GetComponent<RectTransform>().sizeDelta.x,lines * 62f);
		newChat.gameObject.GetComponent<RectTransform> ().transform.Translate(0f, (this.GetComponent<RectTransform>().sizeDelta.y/2f -(newChat.gameObject.GetComponent<RectTransform> ().sizeDelta.y/2  + 10f + currentposition)),0f);

		//newChat.transform.SetParent (this.transform);
		//update the position for the next message
		currentposition += ((lines * 62f) + 10f);

	}
}
