using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Vittu : MonoBehaviour
{
    [SerializeField]
    Text InputField;
    [SerializeField]
    Text LogField;

    string inputString;
    

    public void Pressed()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);

        string value = EventSystem.current.currentSelectedGameObject.name;

        if (value == "Enter")
        {
            switch (inputString)
            {
                case "0000":
                    Debug.Log(0000);
                    inputString = "0000";
                    LogField.text += inputString + "\n";
                    break;
                case "4568":
                    inputString = "Remove page 1 and take page 2";
                    LogField.text += inputString + "\n";
                    break;
                default:
                    Debug.Log("lol nope");
                    break;
            }
            inputString = "";
            InputField.text = inputString;
        }

        else
        {
            inputString += value;

            InputField.text = inputString;
        }

    }


}
