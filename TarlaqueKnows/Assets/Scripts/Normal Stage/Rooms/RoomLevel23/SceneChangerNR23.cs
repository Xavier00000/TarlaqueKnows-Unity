using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR23 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[22]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel23()
    {
        SceneManager.LoadScene("NormalLevel23");
    }
    public void NormalRoom24()
    {
        SceneManager.LoadScene("NormalRoom24");
    }
}
