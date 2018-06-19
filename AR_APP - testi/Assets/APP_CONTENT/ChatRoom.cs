using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChatRoom : MonoBehaviour {

	public GameObject chat;

	float currentposition = 0f;
	Text chatMessage;
	public Font braile;

	void Start(){currentposition = 0f;
		this.transform.localPosition = new Vector3 (0f,-4000f,0f);}

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
		newChat.gameObject.GetComponent<RectTransform> ().transform.localPosition = new Vector3(0f, (4000f -((lines * 32f)  + 10f + currentposition)),0f);

		//update the position for the next message
		currentposition = currentposition + ((lines * 62f) + 10f);

	}
}
