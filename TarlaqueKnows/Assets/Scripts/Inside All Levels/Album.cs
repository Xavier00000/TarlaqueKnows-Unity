using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Album : MonoBehaviour
{
    public GameObject EasyLevels,NormalLevels,HardLevels,AlbumPanel;
    public GameObject[] LockedPanel;
    public GameObject[] InfoPanels;
    void Start()
    {
        for(int ctr=0; ctr<FinishedLevel.isLevelFinished.Length; ctr++)
        {
            if(FinishedLevel.isLevelFinished[ctr]==true)
            {
                LockedPanel[ctr].SetActive(false);                
            }
        }
    }
    public void ShowAlbum()
    {
        AlbumPanel.SetActive(true);
    }
    public void CloseAlbum()
    {
        AlbumPanel.SetActive(false);
    }
    public void ShowEasy()
    {
        EasyLevels.SetActive(true);
        NormalLevels.SetActive(false);
        HardLevels.SetActive(false);
    }
    public void ShowNormal()
    {
        NormalLevels.SetActive(true);
        EasyLevels.SetActive(false);
        HardLevels.SetActive(false);
    }
    public void ShowHard()
    {
        HardLevels.SetActive(true);
        EasyLevels.SetActive(false);
        NormalLevels.SetActive(false);
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
    public void ShowInfoLvl10()
    {
        InfoPanels[9].SetActive(true);
    }
    public void ShowInfoLvl11()
    {
        InfoPanels[10].SetActive(true);
    }
    public void ShowInfoLvl12()
    {
        InfoPanels[11].SetActive(true);
    }
    public void ShowInfoLvl13()
    {
        InfoPanels[12].SetActive(true);
    }
    public void ShowInfoLvl14()
    {
        InfoPanels[13].SetActive(true);
    }
    public void ShowInfoLvl15()
    {
        InfoPanels[14].SetActive(true);
    }
    public void ShowInfoLvl16()
    {
        InfoPanels[15].SetActive(true);
    }
    public void ShowInfoLvl17()
    {
        InfoPanels[16].SetActive(true);
    }
    public void ShowInfoLvl18()
    {
        InfoPanels[17].SetActive(true);
    }
    public void ShowInfoLvl19()
    {
        InfoPanels[18].SetActive(true);
    }
    public void ShowInfoLvl20()
    {
        InfoPanels[19].SetActive(true);
    }
    public void ShowInfoLvl21()
    {
        InfoPanels[20].SetActive(true);
    }
    public void ShowInfoLvl22()
    {
        InfoPanels[21].SetActive(true);
    }
    public void ShowInfoLvl23()
    {
        InfoPanels[22].SetActive(true);
    }
    public void ShowInfoLvl24()
    {
        InfoPanels[23].SetActive(true);
    }
    public void ShowInfoLvl25()
    {
        InfoPanels[24].SetActive(true);
    }
    public void ShowInfoLvl26()
    {
        InfoPanels[25].SetActive(true);
    }
    public void ShowInfoLvl27()
    {
        InfoPanels[26].SetActive(true);
    }
    public void ShowInfoLvl28()
    {
        InfoPanels[27].SetActive(true);
    }
    public void ShowInfoLvl29()
    {
        InfoPanels[28].SetActive(true);
    }
    public void ShowInfoLvl30()
    {
        InfoPanels[29].SetActive(true);
    }
    public void ShowInfoLvl31()
    {
        InfoPanels[30].SetActive(true);
    }
    public void ShowInfoLvl32()
    {
        InfoPanels[31].SetActive(true);
    }
    public void ShowInfoLvl33()
    {
        InfoPanels[32].SetActive(true);
    }
    public void ShowInfoLvl34()
    {
        InfoPanels[33].SetActive(true);
    }
    public void ShowInfoLvl35()
    {
        InfoPanels[34].SetActive(true);
    }
    public void ShowInfoLvl36()
    {
        InfoPanels[35].SetActive(true);
    }
    public void ShowInfoLvl37()
    {
        InfoPanels[36].SetActive(true);
    }
    public void ShowInfoLvl38()
    {
        InfoPanels[37].SetActive(true);
    }
    public void ShowInfoLvl39()
    {
        InfoPanels[38].SetActive(true);
    }
    public void ShowInfoLvl40()
    {
        InfoPanels[39].SetActive(true);
    }
    public void CloseInfolvl01()
    {
        InfoPanels[0].SetActive(false);
    }
    public void CloseInfolvl02()
    {
        InfoPanels[1].SetActive(false);
    }
    public void CloseInfolvl03()
    {
        InfoPanels[2].SetActive(false);
    }
    public void CloseInfolvl04()
    {
        InfoPanels[3].SetActive(false);
    }
    public void CloseInfolvl05()
    {
        InfoPanels[4].SetActive(false);
    }
    public void CloseInfolvl06()
    {
        InfoPanels[5].SetActive(false);
    }
    public void CloseInfolvl07()
    {
        InfoPanels[6].SetActive(false);
    }
    public void CloseInfolvl08()
    {
        InfoPanels[7].SetActive(false);
    }
    public void CloseInfolvl09()
    {
        InfoPanels[8].SetActive(false);
    }
    public void CloseInfolvl10()
    {
        InfoPanels[9].SetActive(false);
    }
    public void CloseInfolvl11()
    {
        InfoPanels[10].SetActive(false);
    }
    public void CloseInfolvl12()
    {
        InfoPanels[11].SetActive(false);
    }
    public void CloseInfolvl13()
    {
        InfoPanels[12].SetActive(false);
    }
    public void CloseInfolvl14()
    {
        InfoPanels[13].SetActive(false);
    }
    public void CloseInfolvl15()
    {
        InfoPanels[14].SetActive(false);
    }
    public void CloseInfolvl16()
    {
        InfoPanels[15].SetActive(false);
    }
    public void CloseInfolvl17()
    {
        InfoPanels[16].SetActive(false);
    }
    public void CloseInfolvl18()
    {
        InfoPanels[17].SetActive(false);
    }
    public void CloseInfolvl19()
    {
        InfoPanels[18].SetActive(false);
    }
    public void CloseInfolvl20()
    {
        InfoPanels[19].SetActive(false);
    }
    public void CloseInfolvl21()
    {
        InfoPanels[20].SetActive(false);
    }
    public void CloseInfolvl22()
    {
        InfoPanels[21].SetActive(false);
    }
    public void CloseInfolvl23()
    {
        InfoPanels[22].SetActive(false);
    }
    public void CloseInfolvl24()
    {
        InfoPanels[23].SetActive(false);
    }
    public void CloseInfolvl25()
    {
        InfoPanels[24].SetActive(false);
    }
    public void CloseInfolvl26()
    {
        InfoPanels[25].SetActive(false);
    }
    public void CloseInfolvl27()
    {
        InfoPanels[26].SetActive(false);
    }
    public void CloseInfolvl28()
    {
        InfoPanels[27].SetActive(false);
    }
    public void CloseInfolvl29()
    {
        InfoPanels[28].SetActive(false);
    }
    public void CloseInfolvl30()
    {
        InfoPanels[29].SetActive(false);
    }
    public void CloseInfolvl31()
    {
        InfoPanels[30].SetActive(false);
    }
    public void CloseInfolvl32()
    {
        InfoPanels[31].SetActive(false);
    }
    public void CloseInfolvl33()
    {
        InfoPanels[32].SetActive(false);
    }
    public void CloseInfolvl34()
    {
        InfoPanels[33].SetActive(false);
    }
    public void CloseInfolvl35()
    {
        InfoPanels[34].SetActive(false);
    }
    public void CloseInfolvl36()
    {
        InfoPanels[35].SetActive(false);
    }
    public void CloseInfolvl37()
    {
        InfoPanels[36].SetActive(false);
    }
    public void CloseInfolvl38()
    {
        InfoPanels[37].SetActive(false);
    }
    public void CloseInfolvl39()
    {
        InfoPanels[38].SetActive(false);
    }
    public void CloseInfolvl40()
    {
        InfoPanels[39].SetActive(false);
    }

}
