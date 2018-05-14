using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotifiedScript : MonoBehaviour {

    bool spotted;
    bool logged;
    [SerializeField]
    Text LogField;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        spotted = this.GetComponent<SayHello>().spotted;
        if (spotted == true && logged == false)
        {
            LogField.text = "hint kuve";
            logged = true;
        }
    }
}
