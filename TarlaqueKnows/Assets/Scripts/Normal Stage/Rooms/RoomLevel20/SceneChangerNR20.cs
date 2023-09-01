using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR20 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[19]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel20()
    {
        SceneManager.LoadScene("NormalLevel20");
    }
    public void NormalRoom21()
    {
        SceneManager.LoadScene("NormalRoom21");
    }
}
