﻿using UnityEngine;

public class ChoicesClicked12 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices12 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer12 btnConScript;
    public GameObject hintsObj;
    Hints12 hintScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices12>();
        btnConScript = btnConParent.GetComponent<ButtonContainer12>();
        hintScript = hintsObj.GetComponent<Hints12>();
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
