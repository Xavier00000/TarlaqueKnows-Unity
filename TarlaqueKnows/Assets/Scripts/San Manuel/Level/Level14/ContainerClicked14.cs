using UnityEngine;

public class ContainerClicked14 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices14 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer14 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices14>();
        btnConScript = btnConParent.GetComponent<ButtonContainer14>();
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
