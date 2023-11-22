using UnityEngine;
public class HintsPuzzle33 : MonoBehaviour
{
    public DragAndDropScript33 DaDScript;
    public GameObject[] HintConfirmBox;
    public GameObject NEHPBox, BackWarningBox;

    public void Hint01()
    {
        HintPointsPuzzle.HintsPoints -= 50;
        HintConfirmBox[0].SetActive(false);
        for (int ctr2 = 0; ctr2 != 1; ctr2++)
        {
            int randomIndex = Random.Range(0, DaDScript.ImageContainer.Length);
            if (DaDScript.isAlreadyCorrect[randomIndex] == false)
            {
                DaDScript.ImageChoices[randomIndex].transform.position = DaDScript.ImageContainer[randomIndex].transform.position;
                DaDScript.isAlreadyCorrect[randomIndex] = true;
                DaDScript.unsolvedPiecesIndex = new int[0];
                DaDScript.unsolvedPiecesCurrentIndex = 0;
                DaDScript.RemainUnsolved();
                DaDScript.isCorrect();
                ctr2 = 1;
                break;
            }
            else
            {
                ctr2 = -1;
            }
        }

    }
    public void Hint02()
    {
        HintPointsPuzzle.HintsPoints -= 150;
        HintConfirmBox[1].SetActive(false);
        for (int ctr = 0; ctr < DaDScript.ImageChoices.Length; ctr++)
        {
            DaDScript.ImageChoices[ctr].transform.position = DaDScript.ImageContainer[ctr].transform.position;
            DaDScript.isAlreadyCorrect[ctr] = true;
        }
        for (int ctr = 0; ctr < DaDScript.isAlreadyCorrect.Length; ctr++)
        {
            DaDScript.isAlreadyCorrect[ctr] = true;
            DaDScript.isCorrect();
        }
    }
    public void ShowHintConfirmBox01()
    {
        if (HintPointsPuzzle.HintsPoints >= 50)
        {
            HintConfirmBox[0].SetActive(true);
            HintConfirmBox[1].SetActive(false);
            NEHPBox.SetActive(false);
            BackWarningBox.SetActive(false);
        }
        else
        {
            NEHPBox.SetActive(true);
            HintConfirmBox[1].SetActive(false);
            HintConfirmBox[0].SetActive(false);
            BackWarningBox.SetActive(false);
        }
    }
    public void ShowHintConfirmBox02()
    {
        if (HintPointsPuzzle.HintsPoints >= 150)
        {
            HintConfirmBox[1].SetActive(true);
            HintConfirmBox[0].SetActive(false);
            NEHPBox.SetActive(false);
            BackWarningBox.SetActive(false);
        }
        else
        {
            NEHPBox.SetActive(true);
            HintConfirmBox[1].SetActive(false);
            HintConfirmBox[0].SetActive(false);
            BackWarningBox.SetActive(false);
        }
    }
    public void CloseHintConfirmBox01()
    {
        HintConfirmBox[0].SetActive(false);
    }
    public void CloseHintConfirmBox02()
    {
        HintConfirmBox[1].SetActive(false);
    }
    public void CloseNEHP()
    {
        NEHPBox.SetActive(false);
        HintConfirmBox[0].SetActive(false);
        HintConfirmBox[1].SetActive(false);
        BackWarningBox.SetActive(false);
    }
}
