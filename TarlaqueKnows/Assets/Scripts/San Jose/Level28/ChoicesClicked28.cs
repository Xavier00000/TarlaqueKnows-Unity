﻿using UnityEngine;

public class ChoicesClicked28 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices28 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer28 btnConScript;
    public GameObject hintsObj;
    Hints28 hintScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices28>();
        btnConScript = btnConParent.GetComponent<ButtonContainer28>();
        hintScript = hintsObj.GetComponent<Hints28>();
    }
    public void btnClicked01()
    {
        for(int ctr=0; ctr<btnConScript.btnConText.Length; ctr++)
        {
            if(btnConScript.btnConText[ctr].text=="")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[0].text;
                btnChoiScript.btnChoices[0].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[0]=true;            
                break;
            }
        }        
    }
    public void btnClicked02()
    {
        for(int ctr=0; ctr<btnConScript.btnConText.Length; ctr++)
        {
            if(btnConScript.btnConText[ctr].text=="")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[1].text;
                btnChoiScript.btnChoices[1].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[1]=true;  
                break;
            }
        }        
    }
    public void btnClicked03()
    {
        for(int ctr=0; ctr<btnConScript.btnConText.Length; ctr++)
        {
            if(btnConScript.btnConText[ctr].text=="")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[2].text;
                btnChoiScript.btnChoices[2].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[2]=true;  
                break;
            }
        }        
    }
    public void btnClicked04()
    {
        for(int ctr=0; ctr<btnConScript.btnConText.Length; ctr++)
        {
            if(btnConScript.btnConText[ctr].text=="")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[3].text;
                btnChoiScript.btnChoices[3].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[3]=true;  
                break;
            }
        }        
    }
   
}
