using UnityEngine;

public class ContainerClicked08 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices08 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer08 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices08>();
        btnConScript = btnConParent.GetComponent<ButtonContainer08>();
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
