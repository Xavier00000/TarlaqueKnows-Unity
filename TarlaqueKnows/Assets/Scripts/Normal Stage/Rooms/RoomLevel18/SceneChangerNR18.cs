using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR18 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[17]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel18()
    {
        SceneManager.LoadScene("NormalLevel18");
    }
    public void NormalRoom19()
    {
        SceneManager.LoadScene("NormalRoom19");
    }
}
