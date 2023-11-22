using UnityEngine;

public class ContainerClicked58 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices58 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer58 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices58>();
        btnConScript = btnConParent.GetComponent<ButtonContainer58>();
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
