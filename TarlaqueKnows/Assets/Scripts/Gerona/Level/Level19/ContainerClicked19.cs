using UnityEngine;

public class ContainerClicked19 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices19 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer19 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices19>();
        btnConScript = btnConParent.GetComponent<ButtonContainer19>();
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
   

}
