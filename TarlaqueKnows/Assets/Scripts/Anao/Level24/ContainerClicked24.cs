using UnityEngine;

public class ContainerClicked24 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices24 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer24 btnConScript;
    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices24>();
        btnConScript = btnConParent.GetComponent<ButtonContainer24>();
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
