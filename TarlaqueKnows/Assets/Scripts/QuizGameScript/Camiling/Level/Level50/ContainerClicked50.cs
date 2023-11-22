using UnityEngine;

public class ContainerClicked50 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices50 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer50 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices50>();
        btnConScript = btnConParent.GetComponent<ButtonContainer50>();
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
