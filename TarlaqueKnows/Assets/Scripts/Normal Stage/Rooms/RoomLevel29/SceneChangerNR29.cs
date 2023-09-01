using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR29 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[28]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel29()
    {
        SceneManager.LoadScene("NormalLevel29");
    }
    public void NormalRoom30()
    {
        SceneManager.LoadScene("NormalRoom30");
    }
}
