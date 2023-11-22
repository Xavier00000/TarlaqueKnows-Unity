using UnityEngine;

public class ContainerClicked62 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices62 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer62 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices62>();
        btnConScript = btnConParent.GetComponent<ButtonContainer62>();
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
