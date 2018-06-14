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
    int[] number = new int[2];
    int[] koodi = new int[4];
    int[] answer = new int[] { 4, 5, 6, 8 };
    string operatorSymbol;
    int i=0;
    int f = 0;
    int n = 0;
    int result;
    bool displayedResults = false;
    bool NotClear = false;



    public void Pressed()
    {
        if (displayedResults == true)
        {
            InputField.text = "";
            inputString = "";
            displayedResults = false;
        }
        if (NotClear == true)
        {
            LogField.text = "";
            NotClear = false;
        }
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);

        string value = EventSystem.current.currentSelectedGameObject.name;
        
        

        int arg;


        if (int.TryParse(value, out arg))
        {
            inputString += value;
            koodi[i] = arg;
            i++;
        }
        else
        {
            switch (value)
            {
                case "+":
                    int.TryParse(inputString, out arg);
                    number[0] = arg;
                    operatorSymbol = value;
                    displayedResults = true;
                    break;
                case "-":
                    int.TryParse(inputString, out arg);
                    number[0] = arg;
                    operatorSymbol = value;
                    displayedResults = true;
                    break;
                case "*":
                    int.TryParse(inputString, out arg);
                    number[0] = arg;
                    operatorSymbol = value;
                    displayedResults = true;
                    break;
                case "/":
                    int.TryParse(inputString, out arg);
                    number[0] = arg;
                    operatorSymbol = value;
                    displayedResults = true;
                    break;
                case "C":
                    inputString = "";
                    InputField.text = "";
                    number = new int[2];
                    koodi = new int[4];
                    i = 0;
                    break;
                case "Enter":
                    
                    if (operatorSymbol != null)
                    {
                        switch (operatorSymbol)
                        {
                            case "+":
                                int.TryParse(inputString, out arg);
                                number[1] = arg;
                                result = number[0] + number[1];
                                break;
                            case "-":
                                int.TryParse(inputString, out arg);
                                number[1] = arg;
                                result = number[0] - number[1];
                                break;
                            case "*":
                                int.TryParse(inputString, out arg);
                                number[1] = arg;
                                result = number[0] * number[1];
                                break;
                            case "/":
                                int.TryParse(inputString, out arg);
                                number[1] = arg;
                                result = number[0] / number[1];
                                break;

                        }
                    }
                    else
                    {
                        foreach (int digit in koodi)
                        {
                            if (koodi[f] == answer[f])
                            {
                                LogField.text += f + 1 + " correct\n";
                            }
                            else
                            {
                                LogField.text += f + 1 + " false\n";
                            }
                            f++;
                        }
                    }


                    displayedResults = true;
                    NotClear = true;
                    inputString = result.ToString();
                    number = new int[2];
                    koodi = new int[4];
                    i = n;
                    f = n;
                    break;
            }
        }

        InputField.text = inputString;
    }
}
