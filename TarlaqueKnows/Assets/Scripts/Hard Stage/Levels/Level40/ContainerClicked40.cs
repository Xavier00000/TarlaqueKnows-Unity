﻿using UnityEngine;

public class ContainerClicked40 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices40 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer40 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices40>();
        btnConScript = btnConParent.GetComponent<ButtonContainer40>();
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
    public void btnClicked02()
    {
        for(int ctr=0; ctr<btnChoiScript.btnChoiText.Length; ctr++)
        {
            if(btnConScript.btnConText[1].text==btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf==false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[1].text="";
                btnConScript.IsCorrect();
                break;
            }
        }        
    }
    public void btnClicked03()
    {
        for(int ctr=0; ctr<btnChoiScript.btnChoiText.Length; ctr++)
        {
            if(btnConScript.btnConText[2].text==btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf==false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[2].text="";
                btnConScript.IsCorrect();
                break;
            }
        }        
    }
    public void btnClicked04()
    {
        for(int ctr=0; ctr<btnChoiScript.btnChoiText.Length; ctr++)
        {
            if(btnConScript.btnConText[3].text==btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf==false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[3].text="";
                btnConScript.IsCorrect();
                break;
            }
        }        
    }
    public void btnClicked05()
    {
        for(int ctr=0; ctr<btnChoiScript.btnChoiText.Length; ctr++)
        {
            if(btnConScript.btnConText[4].text==btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf==false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[4].text="";
                btnConScript.IsCorrect();
                break;
            }
        }        
    }
    public void btnClicked06()
    {
        for(int ctr=0; ctr<btnChoiScript.btnChoiText.Length; ctr++)
        {
            if(btnConScript.btnConText[5].text==btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf==false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[5].text="";
                btnConScript.IsCorrect();
                break;
            }
        }        
    }
}