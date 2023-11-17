using UnityEngine;
using System.IO;

public class SaveLoadManager : MonoBehaviour
{


    private string savePath;
    void Start()
    {
        savePath = Application.persistentDataPath + "/LevelForTarlac.json";
        LoadGameData();

       
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
