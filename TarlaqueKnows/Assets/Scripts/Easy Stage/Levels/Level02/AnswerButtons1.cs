using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons1 : MonoBehaviour
{

    public Text answerText;

    public void CheckAnswer()
    {
        if (answerText.text == "SAN MANUEL") // Check if the selected answer is correct
        {
            Debug.Log("Wrong!");
        }

    }
}
