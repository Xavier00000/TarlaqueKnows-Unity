using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerHR31 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {        
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[30]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void HardLevel31()
    {
        SceneManager.LoadScene("HardLevel31");
    }
    public void HardRoom32()
    {
        SceneManager.LoadScene("HardRoom32");
    }
}
