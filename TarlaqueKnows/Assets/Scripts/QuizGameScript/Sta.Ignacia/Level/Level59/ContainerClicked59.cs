﻿using UnityEngine;

public class ContainerClicked59 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices59 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer59 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices59>();
        btnConScript = btnConParent.GetComponent<ButtonContainer59>();
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
        for (int ctr = 0; ctr < btnChoiScript.btnChoiText.Length; ctr++)
        {
            if (btnConScript.btnConText[4].text == btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf == false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[4].text = "";
                btnConScript.IsCorrect();
                break;
            }
        }

    }
    public void btnClicked06()
    {
        for (int ctr = 0; ctr < btnChoiScript.btnChoiText.Length; ctr++)
        {
            if (btnConScript.btnConText[5].text == btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf == false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[5].text = "";
                btnConScript.IsCorrect();
                break;
            }
        }

    }
    public void btnClicked07()
    {
        for (int ctr = 0; ctr < btnChoiScript.btnChoiText.Length; ctr++)
        {
            if (btnConScript.btnConText[6].text == btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf == false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[6].text = "";
                btnConScript.IsCorrect();
                break;
            }
        }

    }
    public void btnClicked08()
    {
        for (int ctr = 0; ctr < btnChoiScript.btnChoiText.Length; ctr++)
        {
            if (btnConScript.btnConText[7].text == btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf == false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[7].text = "";
                btnConScript.IsCorrect();
                break;
            }
        }

    }
    public void btnClicked09()
    {
        for (int ctr = 0; ctr < btnChoiScript.btnChoiText.Length; ctr++)
        {
            if (btnConScript.btnConText[8].text == btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf == false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[8].text = "";
                btnConScript.IsCorrect();
                break;
            }
        }

    }
    public void btnClicked10()
    {
        for (int ctr = 0; ctr < btnChoiScript.btnChoiText.Length; ctr++)
        {
            if (btnConScript.btnConText[9].text == btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf == false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[9].text = "";
                btnConScript.IsCorrect();
                break;
            }
        }

    }
    public void btnClicked11()
    {
        for (int ctr = 0; ctr < btnChoiScript.btnChoiText.Length; ctr++)
        {
            if (btnConScript.btnConText[10].text == btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf == false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[10].text = "";
                btnConScript.IsCorrect();
                break;
            }
        }

    }
    public void btnClicked12()
    {
        for (int ctr = 0; ctr < btnChoiScript.btnChoiText.Length; ctr++)
        {
            if (btnConScript.btnConText[11].text == btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf == false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[11].text = "";
                btnConScript.IsCorrect();
                break;
            }
        }

    }
    public void btnClicked013()
    {
        for (int ctr = 0; ctr < btnChoiScript.btnChoiText.Length; ctr++)
        {
            if (btnConScript.btnConText[12].text == btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf == false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[12].text = "";
                btnConScript.IsCorrect();
                break;
            }
        }

    }
    public void btnClicked14()
    {
        for (int ctr = 0; ctr < btnChoiScript.btnChoiText.Length; ctr++)
        {
            if (btnConScript.btnConText[13].text == btnChoiScript.btnChoiText[ctr].text && btnChoiScript.btnChoices[ctr].activeSelf == false)
            {
                btnChoiScript.btnChoices[ctr].SetActive(true);
                btnConScript.btnConText[13].text = "";
                btnConScript.IsCorrect();
                break;
            }
        }

    }
}