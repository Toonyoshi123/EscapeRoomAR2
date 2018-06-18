using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elementals : MonoBehaviour {

	bool spotted = false;
	bool notified = false;
	public GameObject phoenix;

	// Update is called once per frame
	void Update () {
		spotted = GetComponent<SayHello> ().spotted;

		if (spotted == true) {
			if (this.gameObject.name == "Fire Marker"  && !notified) {
				phoenix.GetComponent<ChatRoom> ().NewLine ("Good day Engineer, this code will be provided for solving the box.", 1f, false);
				phoenix.GetComponent<ChatRoom> ().NewLine ("Gamma One", 1f, true);
				notified = true;
			} else if (this.gameObject.name == "Air Marker"  && !notified) {
				phoenix.GetComponent<ChatRoom> ().NewLine ("Good day Engineer, this code will be provided for solving the box.", 1f, false);
				phoenix.GetComponent<ChatRoom> ().NewLine ("Delta Five", 1f, true);
				notified = true;
			} else if (this.gameObject.name == "Water Marker"  && !notified) {
				phoenix.GetComponent<ChatRoom> ().NewLine ("Good day Engineer, this code will be provided for solving the box.", 1f, false);
				phoenix.GetComponent<ChatRoom> ().NewLine ("Alpha Three", 1f, true);
				notified = true;
			} else if (this.gameObject.name == "Earth Marker"  && !notified) {
				phoenix.GetComponent<ChatRoom> ().NewLine ("Good day Engineer, this code will be provided for solving the box.", 1f, false);
				phoenix.GetComponent<ChatRoom> ().NewLine ("Beta Two -- Diamond", 1f, true);
				notified = true;
			}
		}
	}}
