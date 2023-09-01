using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerHR35 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {        
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[34]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void HardLevel35()
    {
        SceneManager.LoadScene("HardLevel35");
    }
    public void HardRoom36()
    {
        SceneManager.LoadScene("HardRoom36");
    }
}
