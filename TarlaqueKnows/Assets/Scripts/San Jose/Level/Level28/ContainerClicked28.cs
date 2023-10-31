using UnityEngine;

public class ContainerClicked28 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices28 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer28 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices28>();
        btnConScript = btnConParent.GetComponent<ButtonContainer28>();
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
