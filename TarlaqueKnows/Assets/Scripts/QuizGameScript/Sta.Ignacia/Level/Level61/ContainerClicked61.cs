using UnityEngine;

public class ContainerClicked61 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices61 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer61 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices61>();
        btnConScript = btnConParent.GetComponent<ButtonContainer61>();
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

    public void btnClicked010()
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
    public void btnClicked011()
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
    public void btnClicked012()
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





}
