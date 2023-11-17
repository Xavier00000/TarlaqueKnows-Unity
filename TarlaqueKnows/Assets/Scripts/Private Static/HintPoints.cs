using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class HintPoints : MonoBehaviour
{
    public static int HintsPoints = 300;
    public static int trials=0;
    public static int puzzleTrials=0;
    float time=0;
    public Text hintPnts;
    private string savePath;

    void Update()
    {
        savePath = Application.persistentDataPath + "/hntPoints.json";
        LoadGameData();

        if (HintsPoints<0)
        {
            hintPnts.text = "Hint Points : 0";
        }
        hintPnts.text = "Hint Points : " + HintsPoints;
        if(trials==2)
        {
            HintsPoints-=25;
            hintPnts.color = Color.red;
            time++;
            trials=0;            
        }
        if(puzzleTrials==2)
        {
            HintsPoints-=25;
            hintPnts.color = Color.red;
            time++;
            puzzleTrials=0;            
        }
        if(time > 0)
        {
            time+=Time.deltaTime;
            if(time >= 2)
            {
                hintPnts.color = Color.white;  
                time=0; 
                puzzleTrials=0;
            }
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
