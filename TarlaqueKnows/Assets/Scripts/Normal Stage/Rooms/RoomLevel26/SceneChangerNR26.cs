using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR26 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[25]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel26()
    {
        SceneManager.LoadScene("NormalLevel26");
    }
    public void NormalRoom27()
    {
        SceneManager.LoadScene("NormalRoom27");
    }
}
