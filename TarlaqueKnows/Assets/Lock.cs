using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
   
    public GameObject[] LockedPanel;
    public GameObject[] InfoPanels;
    void Start()
    {
        for (int ctr = 0; ctr < FinishedLevel.isLevelFinished.Length; ctr++)
        {
            if (FinishedLevel.isLevelFinished[ctr] == true)
            {
                LockedPanel[ctr].SetActive(false);
            }
        }
    }
 
   


    public void ShowInfoLvl01()
    {
        InfoPanels[0].SetActive(true);
    }
    public void ShowInfoLvl02()
    {
        InfoPanels[1].SetActive(true);
    }
    public void ShowInfoLvl03()
    {
        InfoPanels[2].SetActive(true);
    }
    public void ShowInfoLvl04()
    {
        InfoPanels[3].SetActive(true);
    }
    public void ShowInfoLvl05()
    {
        InfoPanels[4].SetActive(true);
    }
    public void ShowInfoLvl06()
    {
        InfoPanels[5].SetActive(true);
    }
    public void ShowInfoLvl07()
    {
        InfoPanels[6].SetActive(true);
    }
    public void ShowInfoLvl08()
    {
        InfoPanels[7].SetActive(true);
    }
    public void ShowInfoLvl09()
    {
        InfoPanels[8].SetActive(true);
    }
    public void ShowInfoLvl010()
    {
        InfoPanels[9].SetActive(true);
    }
    

}
