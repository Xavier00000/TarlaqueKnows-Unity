﻿using UnityEngine;

public class ContainerClicked54 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices54 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer54 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices54>();
        btnConScript = btnConParent.GetComponent<ButtonContainer54>();
    }
    public void btnClicked01()
    {
        for(int ctr=0; ctr<btnChoiScript.btnChoiText.Length; ctr++)
        {
            if(btnConScript.btnConText[0].text==btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf==false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[0].text="";
               
                btnConScript.IsCorrect();
                break;
            }
        }        
    }
   






}