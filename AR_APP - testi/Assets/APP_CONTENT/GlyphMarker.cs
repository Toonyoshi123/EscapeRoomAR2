using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlyphMarker : MonoBehaviour {

	bool spotted = false;
	bool notified = false;
	public GameObject phoenix;
	// Update is called once per frame
	void Update () {
		spotted = GetComponent<SayHello>().spotted;

		if(spotted == true && !notified)
		{
			phoenix.GetComponentInChildren<ChatRoom> ().NewLine ("Good day Engineer,\n These logs are provided for your convenience. Work quickly and help Phoenix engage.",1f,false);
			notified = true;
		}
	}
}
