using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR22 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[21]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel22()
    {
        SceneManager.LoadScene("NormalLevel22");
    }
    public void NormalRoom23()
    {
        SceneManager.LoadScene("NormalRoom23");
    }
}
