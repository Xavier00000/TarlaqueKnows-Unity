using UnityEngine;

public class ChoicesClicked40 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices40 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer40 btnConScript;
    public GameObject hintsObj;
    Hints40 hintScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices40>();
        btnConScript = btnConParent.GetComponent<ButtonContainer40>();
        hintScript = hintsObj.GetComponent<Hints40>();
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
