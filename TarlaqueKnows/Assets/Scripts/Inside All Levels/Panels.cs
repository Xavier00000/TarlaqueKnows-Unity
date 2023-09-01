using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panels : MonoBehaviour
{
    public GameObject optionPanel;
    public void OptionPanel()
    {
        optionPanel.SetActive(true);
    }
    public void CloseOptionPanel()
    {
        optionPanel.SetActive(false);
    }
}
