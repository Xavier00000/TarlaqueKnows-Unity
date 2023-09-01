using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR16 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[15]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel16()
    {
        SceneManager.LoadScene("NormalLevel16");
    }
    public void NormalRoom17()
    {
        SceneManager.LoadScene("NormalRoom17");
    }
}
