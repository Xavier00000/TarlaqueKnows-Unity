using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerHR32 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {        
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[31]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void HardLevel32()
    {
        SceneManager.LoadScene("HardLevel32");
    }
    public void HardRoom33()
    {
        SceneManager.LoadScene("HardRoom33");
    }
}
