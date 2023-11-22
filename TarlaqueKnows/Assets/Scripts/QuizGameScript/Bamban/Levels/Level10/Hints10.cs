using UnityEngine;
public class Hints10 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices10 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer10 btnConScript;
    int hint1 = 0;
    string[] answer = { "15" };
    bool[] isAlreadyAnswer = new bool[1];
    public bool[] isAlreadyFalse = new bool[4];
    public GameObject[] HintConfirmBox;
    public GameObject NoEnHiPoBox,ReMaHiPoBox;
    int numTap=0;

    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices10>();
        btnConScript = btnConParent.GetComponent<ButtonContainer10>();
        for(int ctr=0; ctr>isAlreadyAnswer.Length; ctr++)
        {
            isAlreadyAnswer[ctr] = false;
        }
        for(int ctr2=0; ctr2<isAlreadyFalse.Length; ctr2++)
        {
            isAlreadyFalse[ctr2]=false;
        }
        
    }
    void Update()
    {
        for(int ctr=0; ctr<isAlreadyFalse.Length; ctr++)
        {
                if(btnChoiScript.btnChoices[ctr].activeSelf==false)
                {
                    isAlreadyFalse[ctr]=true;
                }
                else
                {
                    isAlreadyFalse[ctr]=false;
                }
            
        }
    }
    
    //---------------------------------------------------Hint01----------------------------------------------------
    public void HintClicked01()
    {
        HintConfirmBox[0].SetActive(false);
        HintPoints.HintsPoints-=80;
        numTap++;
        if(hint1==0)
        {            
            for(int ctr=0; ctr<btnConScript.btnContainer.Length; ctr++)
            {
                for(int ctr2=0; ctr2<btnChoiScript.btnChoices.Length; ctr2++)
                {
                    if(btnConScript.btnConText[ctr].text=="BATTLE OF TIRAD PASS")
                    {
                        btnConScript.btnConText[ctr].text="";
                    }
                }                           
            }
            for(int ctr=0; ctr<btnChoiScript.btnChoices.Length; ctr++)
            {
                if(btnChoiScript.btnChoiText[ctr].text== "BATTLE OF TIRAD PASS")
                {
                    btnChoiScript.btnChoices[ctr].SetActive(false);
                }
                
            }
            hint1++;
        }
        else if(hint1==1)
        {
            for(int ctr=0; ctr<btnConScript.btnContainer.Length; ctr++)
            {
                if(btnConScript.btnConText[ctr].text== "BATTLE OF MACTAN")
                {
                    btnConScript.btnConText[ctr].text="";
                }
                        
            }
            for(int ctr=0; ctr<btnChoiScript.btnChoices.Length; ctr++)
            {
                if(btnChoiScript.btnChoiText[ctr].text== "BATTLE OF MACTAN")
                {
                    btnChoiScript.btnChoices[ctr].SetActive(false);
                }
                
            }
        }
        btnConScript.IsCorrect();
    } //End hint 1
      //---------------------------------------------------Hint02-----------------------------------------------------
     public void HintClicked03()
    {
        HintConfirmBox[1].SetActive(false);
        HintPoints.HintsPoints -= 150;
        //Set active all the button that btnChoi words == words to the current btn Container
        int conIndex = 0;
        for (int ctr = 0; ctr < btnChoiScript.btnChoices.Length; ctr++)
        {
            if (conIndex < btnConScript.btnContainer.Length) // If all the btn con is filled, activate this statement below
            {
                if (btnConScript.btnConText[conIndex].text == btnChoiScript.btnChoiText[ctr].text &&
                    btnChoiScript.btnChoices[ctr].activeSelf == false)
                {
                    btnChoiScript.btnChoices[ctr].SetActive(true);
                    conIndex++;
                    ctr = -1;//This will reset the counter to start from the beginning of btn

                }
                else if (btnConScript.btnConText[conIndex].text == "")
                {
                    ctr = -1;
                    conIndex++;
                }
            }
            else if (conIndex == btnConScript.btnContainer.Length)
            {
                break;
            }
        }
        //Put all answers in btn Container OR solve all the remaining unaswered
        for (int ctr = 0; ctr < btnConScript.btnContainer.Length; ctr++)
        {
            btnConScript.btnConText[ctr].text = answer[ctr];
        }
        int Index = 0;
        for (int ctr = 0; ctr < btnChoiScript.btnChoices.Length; ctr++)
        {
            if (Index < btnConScript.btnContainer.Length)
            {
                if (btnChoiScript.btnChoiText[ctr].text == answer[Index] &&
                btnChoiScript.btnChoices[ctr].activeSelf == true)
                {
                    btnChoiScript.btnChoices[ctr].SetActive(false);
                    Index++;
                    ctr = -1;
                    btnConScript.IsCorrect();
                }
            }
            else if (Index == btnConScript.btnContainer.Length)
            {
                break;
            }
        }
    }
    public void ShowHint01Box()
    {
        if (HintPoints.HintsPoints >= 80 && numTap < 2)
        {
            HintConfirmBox[0].SetActive(true);
            HintConfirmBox[1].SetActive(false);
        
            NoEnHiPoBox.SetActive(false);
            ReMaHiPoBox.SetActive(false);
        }
        else if (numTap == 2)
        {
            ReMaHiPoBox.SetActive(true);
            HintConfirmBox[0].SetActive(false);
            HintConfirmBox[1].SetActive(false);
        
            NoEnHiPoBox.SetActive(false);
        }
        else
        {
            NoEnHiPoBox.SetActive(true);
            HintConfirmBox[1].SetActive(false);
            HintConfirmBox[0].SetActive(false);
      
            ReMaHiPoBox.SetActive(false);
        }
    }

    public void ShowHint03Box()
    {
        if (HintPoints.HintsPoints >= 150)
        {
            HintConfirmBox[1].SetActive(true);
            HintConfirmBox[0].SetActive(false);

            NoEnHiPoBox.SetActive(false);
            ReMaHiPoBox.SetActive(false);
        }
        else
        {
            NoEnHiPoBox.SetActive(true);
       
            HintConfirmBox[0].SetActive(false);
            HintConfirmBox[1].SetActive(false);
            ReMaHiPoBox.SetActive(false);
        }
    }
    public void CloseHint01Box()
    {
        HintConfirmBox[0].SetActive(false);
    }
    
    public void CloseHint03Box()
    {
        HintConfirmBox[1].SetActive(false);
    }
    public void CloseNEHPBox()
    {
        NoEnHiPoBox.SetActive(false);
    }
    public void CloseRMHPBox()
    {
        ReMaHiPoBox.SetActive(false);
    }

}

