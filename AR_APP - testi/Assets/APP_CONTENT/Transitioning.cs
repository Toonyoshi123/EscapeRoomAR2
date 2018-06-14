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
	public GameObject notesScreen;

	public void StartTransition(string selectedApp)
	{
		upperHalf.SetActive (true);
		lowerHalf.SetActive (true);

		upperHalf.GetComponentInChildren<Animator> ().Play ("UpperHalfClosing");
		lowerHalf.GetComponentInChildren<Animator> ().Play ("LowerHalfClosing");


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
			notesScreen.SetActive (true);
			homeScreen.SetActive (false);
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
			notesScreen.SetActive (false);
			break;
		}
		StartCoroutine (EndTransition(1f));
	}

	IEnumerator EndTransition(float delay)
	{
		//animation
		upperHalf.GetComponentInChildren<Animator> ().Play ("UpperHalfOpening");
		lowerHalf.GetComponentInChildren<Animator> ().Play ("LowerHalfOpening");

		yield return new WaitForSeconds (delay);

		upperHalf.SetActive (false);
		lowerHalf.SetActive (false);
	}
}
