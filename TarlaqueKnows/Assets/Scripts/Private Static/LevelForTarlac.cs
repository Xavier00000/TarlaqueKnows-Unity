using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class LevelForTarlac : MonoBehaviour
{
    public GameObject[] LockedPanel;
    public GameObject[] InfoPanels;
    public GameObject TarlacCity, Bamban, SanManuel, Conception, Gerona, Anao, SanJose, Victoria, Mayantoc;
    private string savePath;
    void Start()
    {
        savePath = Application.persistentDataPath + "/LevelForTarlac.json";
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


        if ( FinishedLevel.isLevelFinished[0])
        {
            LockedPanel[levelToCheck0].SetActive(false);
            TarlacCity.SetActive(false);
        }
        if (FinishedLevel.isLevelFinished[1])
        {
            LockedPanel[levelToCheck1].SetActive(false);
        }
        if ( FinishedLevel.isLevelFinished[2])
        {
            LockedPanel[levelToCheck2].SetActive(false);
        }
        if (FinishedLevel.isLevelFinished[3])
        {
            LockedPanel[levelToCheck3].SetActive(false);
        }
        if ( FinishedLevel.isLevelFinished[4])
        {
            LockedPanel[levelToCheck4].SetActive(false);
            Bamban.SetActive(false);
        }
        if (FinishedLevel.isLevelFinished[5])
        {
            LockedPanel[levelToCheck5].SetActive(false);
        }
        if (FinishedLevel.isLevelFinished[6])
        {
            LockedPanel[levelToCheck6].SetActive(false);
        }
        if (FinishedLevel.isLevelFinished[7])
        {
            LockedPanel[levelToCheck7].SetActive(false);
        }

       
    }


    public void SaveGameData()
    {
        SaveData data = new SaveData();
        data.isLevelFinished = FinishedLevel.isLevelFinished;

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
                FinishedLevel.isLevelFinished = data.isLevelFinished;
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