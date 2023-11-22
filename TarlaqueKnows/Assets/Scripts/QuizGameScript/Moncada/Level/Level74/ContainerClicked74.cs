using UnityEngine;

public class ContainerClicked74 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices74 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer74 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices74>();
        btnConScript = btnConParent.GetComponent<ButtonContainer74>();
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
