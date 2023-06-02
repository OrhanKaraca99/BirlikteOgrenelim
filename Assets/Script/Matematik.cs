using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Matematik : MonoBehaviour
{
    public TMP_InputField[] inputFields;
    public Button checkButton;
    public TextMeshProUGUI kontroltext;

    private int[] correctValues = { 3, 6, 12, 4 };
    SonScript son_script;

    private void Start()
    {
        checkButton.onClick.AddListener(CheckFields);
        son_script = GameObject.Find("sonuncu").GetComponent<SonScript>();
    }

    private void CheckFields()
    {
        bool allFieldsCorrect = true;

        for (int i = 0; i < inputFields.Length; i++)
        {
            int inputValue;
            if (int.TryParse(inputFields[i].text, out inputValue))
            {
                if (inputValue != correctValues[i])
                {
                    allFieldsCorrect = false;
                    break;
                }
            }
            else
            {
                allFieldsCorrect = false;
                break;
            }
        }

        if (allFieldsCorrect)
        {
            kontroltext.text = "Tebrikler!";
            son_script.level_son_matematik();

        }
        else
        {
            kontroltext.text = "Yanlış değerler girildi";
        }
    }
}
