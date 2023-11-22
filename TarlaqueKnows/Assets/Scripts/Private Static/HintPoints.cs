using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class HintPoints : MonoBehaviour
{
    public static int HintsPoints = 300;
    public static int trials = 0;
    public static int puzzleTrials = 0;
    float time = 0;
    public Text hintPnts;

    private string savePath;

    private void Start()
    {
        // Set the save path. You can customize this path based on your needs.
        savePath = Path.Combine(Application.persistentDataPath, "hintPoints.json");
        LoadData();
    }

    void Update()
    {
        if (HintsPoints < 0)
        {
            hintPnts.text = "Hint Points : 0";
        }
        else
        {
            hintPnts.text = "Hint Points : " + HintsPoints;
        }

        if (trials == 2 || puzzleTrials == 2)
        {
            HintsPoints -= 25;
            hintPnts.color = Color.red;
            time++;
            trials = 0;
            puzzleTrials = 0;
        }

        if (time > 0)
        {
            time += Time.deltaTime;
            if (time >= 2)
            {
                hintPnts.color = Color.white;
                time = 0;
            }
        }

        // Save data every frame (you may want to optimize this based on your needs)
        SaveData();
    }

    private void SaveData()
    {
        HintPointsData data = new HintPointsData
        {
            HintsPoints = HintsPoints,
            trials = trials,
            puzzleTrials = puzzleTrials
        };

        string jsonData = JsonUtility.ToJson(data);
        File.WriteAllText(savePath, jsonData);
    }

    private void LoadData()
    {
        if (File.Exists(savePath))
        {
            string jsonData = File.ReadAllText(savePath);
            HintPointsData data = JsonUtility.FromJson<HintPointsData>(jsonData);

            HintsPoints = data.HintsPoints;
            trials = data.trials;
            puzzleTrials = data.puzzleTrials;
        }
    }
    [System.Serializable]
    public class HintPointsData
    {
        public int HintsPoints;
        public int trials;
        public int puzzleTrials;
    }

}
