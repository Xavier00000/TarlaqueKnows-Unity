using UnityEngine;
using System.IO;

public class SaveLoadManagerPuzzle : MonoBehaviour
{


    private string savePath;
    void Start()
    {
        savePath = Application.persistentDataPath + "/Puzzle.json";
        LoadGameData();

       
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
