using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AMark : MonoBehaviour {

    bool spotted;
    bool logged;
    public GameObject mark;
    public GameObject chart;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spotted = this.GetComponent<SayHello>().spotted;
        if (spotted == true)
        {
            mark.SetActive(true);
        }
        if (logged == false)
        {
            chart.SetActive(true);
            logged = true;
        }
    }
}
