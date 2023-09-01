using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR17 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[16]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel17()
    {
        SceneManager.LoadScene("NormalLevel17");
    }
    public void NormalRoom18()
    {
        SceneManager.LoadScene("NormalRoom18");
    }
}
