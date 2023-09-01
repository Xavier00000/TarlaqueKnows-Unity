using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER14 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[13]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel14()
    {
        SceneManager.LoadScene("EasyLevel14");
    }
    public void EasyRoom15()
    {
        SceneManager.LoadScene("EasyRoom15");
    }
}
