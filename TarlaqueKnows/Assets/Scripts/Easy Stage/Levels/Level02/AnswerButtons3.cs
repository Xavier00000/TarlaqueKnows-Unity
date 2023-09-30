using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons3 : MonoBehaviour
{

    public Text answerText;

    public void CheckAnswer()
    {
        if (answerText.text == "GERONA") // Check if the selected answer is correct
        {
            Debug.Log("Wrong!");
        }
    }
}
