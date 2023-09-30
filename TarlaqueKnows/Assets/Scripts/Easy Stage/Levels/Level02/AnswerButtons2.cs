using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons2 : MonoBehaviour
{

    public Text answerText;

    public void CheckAnswer()
    {
        if (answerText.text == "SAN JOSE") // Check if the selected answer is correct
        {
            Debug.Log("Wrong!");
        }
       
    }
}
