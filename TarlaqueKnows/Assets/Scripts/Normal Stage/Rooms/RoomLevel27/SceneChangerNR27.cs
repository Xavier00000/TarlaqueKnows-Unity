using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR27 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[26]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel27()
    {
        SceneManager.LoadScene("NormalLevel27");
    }
    public void NormalRoom28()
    {
        SceneManager.LoadScene("NormalRoom28");
    }
}
