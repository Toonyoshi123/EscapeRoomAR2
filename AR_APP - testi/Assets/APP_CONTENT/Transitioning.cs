using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transitioning : MonoBehaviour {

	[SerializeField]
	GameObject upperHalf;
	[SerializeField]
	GameObject lowerHalf;

	public GameObject calculator;
	public GameObject camera;
	public GameObject homeScreen;
	public GameObject cameraButton;
	public GameObject audioScreen;
	public GameObject messagesScreen;

	public void StartTransition(string selectedApp)
	{
		upperHalf.SetActive (true);
		lowerHalf.SetActive (true);

		upperHalf.GetComponent<Animator> ().Play ("UpperHalfClosing");
		lowerHalf.GetComponent<Animator> ().Play ("LowerHalfClosing");


		StartCoroutine (SwitchApp(selectedApp, 1f));
	}

	IEnumerator SwitchApp(string selectedApp, float delay)
	{
		yield return new WaitForSeconds (delay);

		switch (selectedApp) {
		case "calculator":
			homeScreen.SetActive (false);
			calculator.SetActive (true);
			break;
		case "camera":
			homeScreen.SetActive (false);
			camera.SetActive (true);
			cameraButton.SetActive (true);
			break;
		case "recordings":
			homeScreen.SetActive (false);
			audioScreen.SetActive (true);
			break;
		case "notes":

			break;
		case "messages":
			homeScreen.SetActive (false);
			messagesScreen.SetActive (true);
			break;
		default:
			camera.SetActive (false);
			calculator.SetActive (false);
			homeScreen.SetActive (true);
			cameraButton.SetActive (false);
			audioScreen.SetActive (false);
			messagesScreen.SetActive (false);
			break;
		}
		StartCoroutine (EndTransition(1f));
	}

	IEnumerator EndTransition(float delay)
	{
		//animation
		upperHalf.GetComponent<Animator> ().Play ("UpperHalfOpening");
		lowerHalf.GetComponent<Animator> ().Play ("LowerHalfOpening");

		yield return new WaitForSeconds (delay);

		upperHalf.SetActive (false);
		lowerHalf.SetActive (false);
	}
}
