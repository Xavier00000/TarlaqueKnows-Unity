using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerHR40 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {        
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[39]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void HardLevel40()
    {
        SceneManager.LoadScene("HardLevel40");
    }
    public void Outside()
    {
        SceneManager.LoadScene("Outside");
    }
}
