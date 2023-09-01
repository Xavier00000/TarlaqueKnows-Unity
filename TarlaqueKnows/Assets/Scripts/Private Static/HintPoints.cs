using UnityEngine;
using UnityEngine.UI;

public class HintPoints : MonoBehaviour
{
    public static int HintsPoints = 300;
    public static int trials=0;
    public static int puzzleTrials=0;
    float time=0;
    public Text hintPnts;

    void Update()
    {
        if(HintsPoints<0)
        {
            hintPnts.text = "Hint Points : 0";
        }
        hintPnts.text = "Hint Points : " + HintsPoints;
        if(trials==3)
        {
            HintsPoints-=25;
            hintPnts.color = Color.red;
            time++;
            trials=0;            
        }
        if(puzzleTrials==3)
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
    
}
