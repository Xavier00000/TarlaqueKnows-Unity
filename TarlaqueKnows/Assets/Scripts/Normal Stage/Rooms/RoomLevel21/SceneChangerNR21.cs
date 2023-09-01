using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR21 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[20]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel21()
    {
        SceneManager.LoadScene("NormalLevel21");
    }
    public void NormalRoom22()
    {
        SceneManager.LoadScene("NormalRoom22");
    }
}
