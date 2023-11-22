using UnityEngine;

public class ContainerClicked40 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices400 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer40 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices400>();
        btnConScript = btnConParent.GetComponent<ButtonContainer40>();
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
