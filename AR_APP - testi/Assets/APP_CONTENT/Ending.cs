using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour {
    bool spotted;
    [SerializeField]
    GameObject timer;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        spotted = GetComponent<SayHello>().spotted;
        if (spotted == true)
        {
            //turn off timer
            timer.GetComponent<Timer>().diffused = true;
        }
    }
}
