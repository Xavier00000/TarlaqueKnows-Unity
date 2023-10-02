using UnityEngine;

public class ContainerClicked02 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices02 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer02 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices02>();
        btnConScript = btnConParent.GetComponent<ButtonContainer02>();
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
