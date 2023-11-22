using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LockPuzzle : MonoBehaviour
{

    public GameObject[] LockedPanel;
    public GameObject[] InfoPanels;
    public GameObject TarlacCity, Bamban,Capas, Mayantoc,Conception,SanClemente,Camiling, Paniqui,Anao,Victoria, Gerona, SanJose,   Ramos, StaIgnacia, LaPaz, Pura, Moncada, SanManuel;
    private string savePath;
    void Start()
    {
        savePath = Application.persistentDataPath + "/Puzzle.json";
        LoadGameData();

        int levelToCheck0 = 0;
        int levelToCheck1 = 1;
        int levelToCheck2 = 2;
        int levelToCheck3 = 3;
        int levelToCheck4 = 4;
        int levelToCheck5 = 5;
        int levelToCheck6 = 6;
        int levelToCheck7 = 7;
        int levelToCheck8 = 8;
        int levelToCheck9 = 9;
        int levelToCheck10 = 10;
        int levelToCheck11 = 11;
        int levelToCheck12 = 12;
        int levelToCheck13 = 13;
        int levelToCheck14 = 14;
        int levelToCheck15 = 15;
        int levelToCheck16 = 16;
        int levelToCheck17 = 17;
        int levelToCheck18 = 18;
        int levelToCheck19 = 19;
        int levelToCheck20 = 20;
        int levelToCheck21 = 21;
        int levelToCheck22 = 22;
        int levelToCheck23 = 23;
        int levelToCheck24 = 24;
        int levelToCheck25 = 25;
        int levelToCheck26 = 26;
        int levelToCheck27 = 27;
        int levelToCheck28 = 28;
        int levelToCheck29 = 29;
        int levelToCheck30 = 30;
        int levelToCheck31 = 31;
        int levelToCheck32 = 32;
        int levelToCheck33 = 33;
        int levelToCheck34 = 34;
        int levelToCheck35 = 35;
        int levelToCheck36 = 36;
        int levelToCheck37 = 37;
        int levelToCheck38 = 38;
        int levelToCheck39 = 39;
        int levelToCheck40 = 40;
        int levelToCheck41 = 41;
        int levelToCheck42 = 42;
        int levelToCheck43 = 43;
        int levelToCheck44 = 44;
        int levelToCheck45 = 45;
        int levelToCheck46 = 46;
        int levelToCheck47 = 47;
        int levelToCheck48 = 48;
        int levelToCheck49 = 49;
        int levelToCheck50 = 50;
        int levelToCheck51 = 51;
        int levelToCheck52 = 52;
        int levelToCheck53 = 53;
        int levelToCheck54 = 54;
        int levelToCheck55 = 55;
        int levelToCheck56 = 56;
        int levelToCheck57 = 57;
        int levelToCheck58 = 58;
        int levelToCheck59 = 59;
        int levelToCheck60 = 60;
        int levelToCheck61 = 61;
        int levelToCheck62 = 62;
        int levelToCheck63 = 63;
        int levelToCheck64 = 64;
        int levelToCheck65 = 65;
        int levelToCheck66 = 66;
        int levelToCheck67 = 67;
        int levelToCheck68 = 68;
        int levelToCheck69 = 69;
        int levelToCheck70 = 70;
        int levelToCheck71 = 71;
        int levelToCheck72 = 72;
        int levelToCheck73 = 73;






        if (FinishedLevelP.isLevelFinished[0])
        {
            LockedPanel[levelToCheck0].SetActive(false);
            TarlacCity.SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[1])
        {
            LockedPanel[levelToCheck1].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[2])
        {
            LockedPanel[levelToCheck2].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[3])
        {
            LockedPanel[levelToCheck3].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[4])
        {
            LockedPanel[levelToCheck4].SetActive(false);
            Bamban.SetActive(false);
        }






        if (FinishedLevelP.isLevelFinished[5])
        {
            LockedPanel[levelToCheck5].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[6])
        {
            LockedPanel[levelToCheck6].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[7])
        {
            LockedPanel[levelToCheck7].SetActive(false);
        }

        if (FinishedLevelP.isLevelFinished[8])
        {
            LockedPanel[levelToCheck8].SetActive(false);
            Capas.SetActive(false);
        }








        if (FinishedLevelP.isLevelFinished[9])
        {
            LockedPanel[levelToCheck9].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[10])
        {
            LockedPanel[levelToCheck10].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[11])
        {
            LockedPanel[levelToCheck11].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[12])
        {
            Mayantoc.SetActive(false);
            LockedPanel[levelToCheck12].SetActive(false);
        }








        if (FinishedLevelP.isLevelFinished[13])
        {
            LockedPanel[levelToCheck13].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[14])
        {
            LockedPanel[levelToCheck14].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[15])
        {
            LockedPanel[levelToCheck15].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[16])
        {
            Conception.SetActive(false);
            LockedPanel[levelToCheck16].SetActive(false);
        }







        if (FinishedLevelP.isLevelFinished[17])
        {
            LockedPanel[levelToCheck17].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[18])
        {
            LockedPanel[levelToCheck18].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[19])
        {
            LockedPanel[levelToCheck19].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[20])
        {
            SanClemente.SetActive(false);
            LockedPanel[levelToCheck20].SetActive(false);
        }







        if (FinishedLevelP.isLevelFinished[21])
        {
            LockedPanel[levelToCheck21].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[22])
        {
            LockedPanel[levelToCheck22].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[23])
        {
            LockedPanel[levelToCheck23].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[24])
        {
            Camiling.SetActive(false);
            LockedPanel[levelToCheck24].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[25])
        {
            LockedPanel[levelToCheck25].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[26])
        {
            LockedPanel[levelToCheck26].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[27])
        {
            LockedPanel[levelToCheck27].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[28])
        {
            Paniqui.SetActive(false);
            LockedPanel[levelToCheck28].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[29])
        {
            LockedPanel[levelToCheck29].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[30])
        {
            LockedPanel[levelToCheck30].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[31])
        {
            LockedPanel[levelToCheck31].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[32])
        {
            Anao.SetActive(false);
            LockedPanel[levelToCheck32].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[33])
        {
            LockedPanel[levelToCheck33].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[34])
        {
            LockedPanel[levelToCheck34].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[35])
        {
            LockedPanel[levelToCheck35].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[36])
        {
            Capas.SetActive(false);
            LockedPanel[levelToCheck36].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[37])
        {
            LockedPanel[levelToCheck37].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[38])
        {
            LockedPanel[levelToCheck38].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[39])
        {
            LockedPanel[levelToCheck39].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[40])
        {
            Paniqui.SetActive(false);
            LockedPanel[levelToCheck40].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[41])
        {
            LockedPanel[levelToCheck41].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[42])
        {
            LockedPanel[levelToCheck42].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[43])
        {
            LockedPanel[levelToCheck43].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[44])
        {
            Camiling.SetActive(false);
            LockedPanel[levelToCheck44].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[45])
        {
            LockedPanel[levelToCheck45].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[46])
        {
            LockedPanel[levelToCheck46].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[47])
        {
            LockedPanel[levelToCheck47].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[48])
        {
            SanClemente.SetActive(false);
            LockedPanel[levelToCheck48].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[49])
        {
            LockedPanel[levelToCheck49].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[50])
        {
            LockedPanel[levelToCheck50].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[51])
        {
            LockedPanel[levelToCheck51].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[52])
        {
            Ramos.SetActive(false);
            LockedPanel[levelToCheck52].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[53])
        {
            LockedPanel[levelToCheck53].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[54])
        {
            LockedPanel[levelToCheck54].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[55])
        {
            LockedPanel[levelToCheck55].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[56])
        {
            StaIgnacia.SetActive(false);
            LockedPanel[levelToCheck56].SetActive(false);
        }

        if (FinishedLevelP.isLevelFinished[57])
        {
            LockedPanel[levelToCheck57].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[58])
        {
            LockedPanel[levelToCheck58].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[59])
        {
            LockedPanel[levelToCheck59].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[60])
        {
            LaPaz.SetActive(false);
            LockedPanel[levelToCheck60].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[61])
        {
            LockedPanel[levelToCheck61].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[62])
        {
            LockedPanel[levelToCheck62].SetActive(false);
        }

        if (FinishedLevelP.isLevelFinished[63])
        {
            LockedPanel[levelToCheck63].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[64])
        {
            Pura.SetActive(false);
            LockedPanel[levelToCheck64].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[65])
        {
            LockedPanel[levelToCheck65].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[66])
        {
            LockedPanel[levelToCheck66].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[67])
        {
            LockedPanel[levelToCheck67].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[68])
        {
            Moncada.SetActive(false);
            LockedPanel[levelToCheck68].SetActive(false);
        }

        if (FinishedLevelP.isLevelFinished[69])
        {
            LockedPanel[levelToCheck69].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[70])
        {
            LockedPanel[levelToCheck70].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[71])
        {
            LockedPanel[levelToCheck71].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[72])
        {
            LockedPanel[levelToCheck72].SetActive(false);
        }
        if (FinishedLevelP.isLevelFinished[73])
        {
            LockedPanel[levelToCheck73].SetActive(false);
        }



    }


    public void SaveGameData()
    {
        SaveData data = new SaveData();
        data.isLevelFinished = FinishedLevelP.isLevelFinished;

        string jsonData = JsonUtility.ToJson(data);
        File.WriteAllText(savePath, jsonData);
    }
    void LoadGameData()
    {
        if (File.Exists(savePath))
        {
            string jsonData = File.ReadAllText(savePath);
            SaveData data = JsonUtility.FromJson<SaveData>(jsonData);

            if (data != null)
            {
                FinishedLevelP.isLevelFinished = data.isLevelFinished;
            }
        }
    }

    void OnDestroy()
    {
        SaveGameData();
    }

    [System.Serializable]
    public class SaveData
    {
        public bool[] isLevelFinished;
    }


}
