using UnityEngine;

public class ContainerClicked34 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices34 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer34 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices34>();
        btnConScript = btnConParent.GetComponent<ButtonContainer34>();
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
