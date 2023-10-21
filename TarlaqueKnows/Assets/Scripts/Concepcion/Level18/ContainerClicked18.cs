using UnityEngine;

public class ContainerClicked18 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices18 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer18 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices18>();
        btnConScript = btnConParent.GetComponent<ButtonContainer18>();
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
