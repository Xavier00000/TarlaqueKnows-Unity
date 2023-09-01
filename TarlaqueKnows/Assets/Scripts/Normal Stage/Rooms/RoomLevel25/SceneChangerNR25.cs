using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR25 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[24]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel25()
    {
        SceneManager.LoadScene("NormalLevel25");
    }
    public void NormalRoom26()
    {
        SceneManager.LoadScene("NormalRoom26");
    }
}
