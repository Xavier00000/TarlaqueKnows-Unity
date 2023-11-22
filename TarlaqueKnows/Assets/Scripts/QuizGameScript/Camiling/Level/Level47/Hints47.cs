using UnityEngine;
using UnityEngine.UI;
public class Hints47 : MonoBehaviour
{
    public GameObject btnChoiParent;
    ButtonChoices47 btnChoiScript;
    public GameObject btnConParent;
    ButtonContainer47 btnConScript;
    int hint1 = 0;
    string[] answer = {"M","A","T"};
    bool[] isAlreadyAnswer = new bool[18];
    public bool[] isAlreadyFalse = new bool[18];
    public GameObject[] HintConfirmBox;
    public GameObject NoEnHiPoBox,ReMaHiPoBox;
    int numTap=0;

    void Start()
    {
        btnChoiScript = btnChoiParent.GetComponent<ButtonChoices47>();
        btnConScript = btnConParent.GetComponent<ButtonContainer47>();
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
                    if(btnConScript.btnConText[ctr].text=="G")
                    {
                        btnConScript.btnConText[ctr].text="";
                    }
                    if(btnConScript.btnConText[ctr].text=="O")
                    {
                        btnConScript.btnConText[ctr].text="";
                    }
                    if (btnConScript.btnConText[ctr].text == "N")
                    {
                        btnConScript.btnConText[ctr].text = "";
                    }




                }                           
            }
            for(int ctr=0; ctr<btnChoiScript.btnChoices.Length; ctr++)
            {
                if(btnChoiScript.btnChoiText[ctr].text=="G")
                {
                    btnChoiScript.btnChoices[ctr].SetActive(false);
                }
                if (btnChoiScript.btnChoiText[ctr].text == "O")
                {
                    btnChoiScript.btnChoices[ctr].SetActive(false);
                }
                if (btnChoiScript.btnChoiText[ctr].text == "N")
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
                if(btnConScript.btnConText[ctr].text=="Z")
                {
                    btnConScript.btnConText[ctr].text="";
                }
                if (btnConScript.btnConText[ctr].text == "F")
                {
                    btnConScript.btnConText[ctr].text = "";
                }
                if (btnConScript.btnConText[ctr].text == "G")
                {
                    btnConScript.btnConText[ctr].text = "";
                }


            }
            for(int ctr=0; ctr<btnChoiScript.btnChoices.Length; ctr++)
            {
                if(btnChoiScript.btnChoiText[ctr].text=="Z")
                {
                    btnChoiScript.btnChoices[ctr].SetActive(false);
                }
                if (btnChoiScript.btnChoiText[ctr].text =="F")
                {
                    btnChoiScript.btnChoices[ctr].SetActive(false);
                }
                if (btnChoiScript.btnChoiText[ctr].text == "G")
                {
                    btnChoiScript.btnChoices[ctr].SetActive(false);
                }




            }
        }
        btnConScript.IsCorrect();
    } //End hint 1
    //---------------------------------------------------Hint02-----------------------------------------------------
    public void HintClicked02()
    {
        HintConfirmBox[1].SetActive(false);
        HintPoints.HintsPoints-=50;
        int answerIndex = 0;
        for(int ctr=0; ctr<btnConScript.btnContainer.Length; ctr++)
        {
            if(btnConScript.btnConText[ctr].text!=answer[answerIndex] || 
                btnConScript.btnConText[ctr].text=="")
            {
                //For setting active btn choices if txt of current btn container == txt of btn choices
                //Activating the btn choices
                for(int ctr2=0; ctr2<btnChoiScript.btnChoices.Length; ctr2++)
                {
                    if(btnConScript.btnConText[ctr].text==btnChoiScript.btnChoiText[ctr2].text)
                    {                        
                        btnChoiScript.btnChoices[ctr2].SetActive(true);
                        break;
                    }
                }//End loop 1
                
                //Below line is use to prevent from detecting same words that causing bugs to appear
                isAlreadyAnswer[ctr]=true;      
                btnConScript.btnConText[ctr].text=answer[answerIndex];
                //For setting the other con txt to empty or to "" if the other con txt same as the word of the correct answer 
                for(int ctr2=ctr; ctr2<btnConScript.btnContainer.Length; ctr2++)
                {
                    if(btnConScript.btnConText[ctr2].text == answer[answerIndex] && isAlreadyAnswer[ctr2]==false)
                    {                     
                        btnConScript.btnConText[ctr2].text = "";
                        break;
                    }
                }//End loop 2
                //Hardest hint function I ever encountered && its DONE! OMG I cant believe!
                for(int ctr2=0; ctr2<btnChoiScript.btnChoices.Length; ctr2++)
                {
                    if(btnConScript.btnConText[ctr].text==btnChoiScript.btnChoiText[ctr2].text)//is current answer text == to current btn choices text
                    {
                        int NumOfWords=0;
                        for(int ctr3=0; ctr3<btnChoiScript.btnChoices.Length; ctr3++)
                        {
                            if(btnConScript.btnConText[ctr].text==btnChoiScript.btnChoiText[ctr3].text)
                            {
                                NumOfWords++;
                            }
                        }
                        if(NumOfWords==1)
                        {
                            btnChoiScript.btnChoices[ctr2].SetActive(false);
                            break;
                        }
                        else if(NumOfWords>=2)
                        {
                            bool[] activeState = new bool[3];
                            int activeStateIndex=0;
                            int[] BtnLocationIndex = new int[3];
                            int BtnLocationCurrentIndex=0;
                            for(int ctr3=0; ctr3<btnChoiScript.btnChoiText.Length; ctr3++)
                            {
                                if(btnConScript.btnConText[ctr].text==btnChoiScript.btnChoiText[ctr3].text &&
                                btnChoiScript.btnChoices[ctr3].activeSelf==true)
                                {
                                    activeState[activeStateIndex] = true;
                                    activeStateIndex++;
                                    BtnLocationIndex[BtnLocationCurrentIndex]=ctr3;
                                    BtnLocationCurrentIndex++;                          
                                }
                                else if(btnConScript.btnConText[ctr].text==btnChoiScript.btnChoiText[ctr3].text &&
                                btnChoiScript.btnChoices[ctr3].activeSelf==false)
                                {
                                    activeState[activeStateIndex] = false;
                                    activeStateIndex++;
                                    BtnLocationIndex[BtnLocationCurrentIndex]=ctr3;
                                    BtnLocationCurrentIndex++;                          
                                }
                            }
                            bool isSamePrevText = false;
                            for(int ctr3=0; ctr3<ctr; ctr3++)
                            {
                                if(btnConScript.btnConText[ctr].text==btnConScript.btnConText[ctr3].text)
                                {
                                    isSamePrevText=true;
                                }
                            }
                            if((activeState[0] && activeState[1])==true)
                            {
                                btnChoiScript.btnChoices[BtnLocationIndex[0]].SetActive(false);
                                break;
                            }
                            else if(activeState[0]==true && activeState[1]==false)
                            {
                                btnChoiScript.btnChoices[BtnLocationIndex[0]].SetActive(false);
                                break;
                            }
                            else if(activeState[0]==false && activeState[1]==true && isSamePrevText==false)
                            {
                                break;
                            }
                            else if(activeState[0]==false && activeState[1]==true && isSamePrevText==true)
                            {
                                btnChoiScript.btnChoices[BtnLocationIndex[1]].SetActive(false);
                                break;
                            }
                        }               
                    }
                }
                
                btnConScript.IsCorrect();//Activate the void from another script        
                break;
            }
            else
            {
                answerIndex++;
            }
        }
        btnConScript.IsCorrect();
    } //End hint 2
    //-----------------------------------------------------Hint03----------------------------------------------------
    public void HintClicked03()
    {
        HintConfirmBox[2].SetActive(false);
        HintPoints.HintsPoints-=150;
        //Set active all the button that btnChoi words == words to the current btn Container
        int conIndex = 0;
        for(int ctr=0; ctr<btnChoiScript.btnChoices.Length; ctr++)
        {
            if(conIndex<btnConScript.btnContainer.Length) // If all the btn con is filled, activate this statement below
            {
                if(btnConScript.btnConText[conIndex].text == btnChoiScript.btnChoiText[ctr].text &&
                    btnChoiScript.btnChoices[ctr].activeSelf==false)
                {                   
                    btnChoiScript.btnChoices[ctr].SetActive(true);
                    conIndex++;
                    ctr=-1;//This will reset the counter to start from the beginning of btn
                    
                }
                else if(btnConScript.btnConText[conIndex].text=="")
                {
                    ctr=-1;
                    conIndex++;
                }
            }
            else if(conIndex==btnConScript.btnContainer.Length)
            {
                break;
            }            
        }
        //Put all answers in btn Container OR solve all the remaining unaswered
        for(int ctr=0; ctr<btnConScript.btnContainer.Length; ctr++)
        {
            btnConScript.btnConText[ctr].text = answer[ctr];
        }
        int Index = 0;
        for(int ctr=0; ctr<btnChoiScript.btnChoices.Length; ctr++)
        {
            if(Index<btnConScript.btnContainer.Length)
            {
                if(btnChoiScript.btnChoiText[ctr].text == answer[Index] &&
                btnChoiScript.btnChoices[ctr].activeSelf == true)
                {
                    btnChoiScript.btnChoices[ctr].SetActive(false);
                    Index++;
                    ctr=-1;
                    btnConScript.IsCorrect();                   
                }
            }
            else if(Index==btnConScript.btnContainer.Length)
            {
                break;
            }
        }        
    }
    public void ShowHint01Box()
    {        
        if(HintPoints.HintsPoints>=80 && numTap<2)
        {
            HintConfirmBox[0].SetActive(true);
            HintConfirmBox[1].SetActive(false);
            HintConfirmBox[2].SetActive(false);
            NoEnHiPoBox.SetActive(false);
            ReMaHiPoBox.SetActive(false);
        }
        else if(numTap==2)
        {
            ReMaHiPoBox.SetActive(true);
            HintConfirmBox[0].SetActive(false);
            HintConfirmBox[1].SetActive(false);
            HintConfirmBox[2].SetActive(false);
            NoEnHiPoBox.SetActive(false);
        }
        else
        {
            NoEnHiPoBox.SetActive(true);
            HintConfirmBox[1].SetActive(false);
            HintConfirmBox[0].SetActive(false);
            HintConfirmBox[2].SetActive(false);
            ReMaHiPoBox.SetActive(false);
        }
    }
    public void ShowHint02Box()
    {
        if(HintPoints.HintsPoints>=50)
        {
            HintConfirmBox[1].SetActive(true);
            HintConfirmBox[0].SetActive(false);
            HintConfirmBox[2].SetActive(false);
            NoEnHiPoBox.SetActive(false);
            ReMaHiPoBox.SetActive(false);
        }
        else
        {
            NoEnHiPoBox.SetActive(true);
            HintConfirmBox[1].SetActive(false);
            HintConfirmBox[0].SetActive(false);
            HintConfirmBox[2].SetActive(false);
            ReMaHiPoBox.SetActive(false);
        }
    }
    public void ShowHint03Box()
    {
        if(HintPoints.HintsPoints>=150)
        {
            HintConfirmBox[2].SetActive(true);
            HintConfirmBox[0].SetActive(false);
            HintConfirmBox[1].SetActive(false);
            NoEnHiPoBox.SetActive(false);
            ReMaHiPoBox.SetActive(false);
        }
        else
        {
            NoEnHiPoBox.SetActive(true);
            HintConfirmBox[2].SetActive(false);
            HintConfirmBox[0].SetActive(false);
            HintConfirmBox[1].SetActive(false);            
            ReMaHiPoBox.SetActive(false);
        }
    }
    public void CloseHint01Box()
    {
        HintConfirmBox[0].SetActive(false);
    }
    public void CloseHint02Box()
    {
        HintConfirmBox[1].SetActive(false);
    }
    public void CloseHint03Box()
    {
        HintConfirmBox[2].SetActive(false);
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
