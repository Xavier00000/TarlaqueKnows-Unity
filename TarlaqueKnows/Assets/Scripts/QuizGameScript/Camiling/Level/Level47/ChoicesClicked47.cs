using UnityEngine;

public class ChoicesClicked47 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices47 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer47 btnConScript;
    public GameObject hintsObj;
    Hints47 hintScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices47>();
        btnConScript = btnConParent.GetComponent<ButtonContainer47>();
        hintScript = hintsObj.GetComponent<Hints47>();
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
    public void btnClicked05()
    {
        for(int ctr=0; ctr<btnConScript.btnConText.Length; ctr++)
        {
            if(btnConScript.btnConText[ctr].text=="")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[4].text;
                btnChoiScript.btnChoices[4].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[4]=true;  
                break;
            }
        }        
    }
    public void btnClicked06()
    {
        for(int ctr=0; ctr<btnConScript.btnConText.Length; ctr++)
        {
            if(btnConScript.btnConText[ctr].text=="")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[5].text;
                btnChoiScript.btnChoices[5].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[5]=true;  
                break;
            }
        }        
    }
    public void btnClicked07()
    {
        for(int ctr=0; ctr<btnConScript.btnConText.Length; ctr++)
        {
            if(btnConScript.btnConText[ctr].text=="")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[6].text;
                btnChoiScript.btnChoices[6].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[6]=true;  
                break;
            }
        }        
    }
    public void btnClicked08()
    {
        for(int ctr=0; ctr<btnConScript.btnConText.Length; ctr++)
        {
            if(btnConScript.btnConText[ctr].text=="")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[7].text;
                btnChoiScript.btnChoices[7].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[7]=true;  
                break;
            }
        }        
    }
    public void btnClicked09()
    {
        for(int ctr=0; ctr<btnConScript.btnConText.Length; ctr++)
        {
            if(btnConScript.btnConText[ctr].text=="")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[8].text;
                btnChoiScript.btnChoices[8].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[8]=true;  
                break;
            }
        }        
    }
    public void btnClicked10()
    {
        for(int ctr=0; ctr<btnConScript.btnConText.Length; ctr++)
        {
            if(btnConScript.btnConText[ctr].text=="")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[9].text;
                btnChoiScript.btnChoices[9].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[9]=true;  
                break;
            }
        }        
    }
    public void btnClicked11()
    {
        for(int ctr=0; ctr<btnConScript.btnConText.Length; ctr++)
        {
            if(btnConScript.btnConText[ctr].text=="")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[10].text;
                btnChoiScript.btnChoices[10].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[10]=true;  
                break;
            }
        }        
    }
    public void btnClicked12()
    {
        for(int ctr=0; ctr<btnConScript.btnConText.Length; ctr++)
        {
            if(btnConScript.btnConText[ctr].text=="")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[11].text;
                btnChoiScript.btnChoices[11].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[11]=true;  
                break;
            }
        }        
    }
    public void btnClicked13()
    {
        for (int ctr = 0; ctr < btnConScript.btnConText.Length; ctr++)
        {
            if (btnConScript.btnConText[ctr].text == "")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[12].text;
                btnChoiScript.btnChoices[12].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[12] = true;
                break;
            }
        }
    }
    public void btnClicked14()
    {
        for (int ctr = 0; ctr < btnConScript.btnConText.Length; ctr++)
        {
            if (btnConScript.btnConText[ctr].text == "")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[13].text;
                btnChoiScript.btnChoices[13].SetActive(false);
                btnConScript.IsCorrect();
               
                break;
            }
        }
    }
    public void btnClicked15()
    {
        for (int ctr = 0; ctr < btnConScript.btnConText.Length; ctr++)
        {
            if (btnConScript.btnConText[ctr].text == "")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[14].text;
                btnChoiScript.btnChoices[14].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[14] = true;
                break;
            }
        }
    }
    public void btnClicked16()
    {
        for (int ctr = 0; ctr < btnConScript.btnConText.Length; ctr++)
        {
            if (btnConScript.btnConText[ctr].text == "")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[15].text;
                btnChoiScript.btnChoices[15].SetActive(false);
                btnConScript.IsCorrect();
                hintScript.isAlreadyFalse[15] = true;
                break;
            }
        }
    }
    public void btnClicked17()
    {
        for (int ctr = 0; ctr < btnConScript.btnConText.Length; ctr++)
        {
            if (btnConScript.btnConText[ctr].text == "")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[16].text;
                btnChoiScript.btnChoices[16].SetActive(false);
                btnConScript.IsCorrect();
             
                break;
            }
        }
    }
    public void btnClicked18()
    {
        for (int ctr = 0; ctr < btnConScript.btnConText.Length; ctr++)
        {
            if (btnConScript.btnConText[ctr].text == "")
            {
                btnConScript.btnConText[ctr].text = btnChoiScript.btnChoiText[17].text;
                btnChoiScript.btnChoices[17].SetActive(false);
                btnConScript.IsCorrect();
               
                break;
            }
        }
    }
}
