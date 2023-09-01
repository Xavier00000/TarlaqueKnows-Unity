using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerHR38 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {        
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[37]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void HardLevel38()
    {
        SceneManager.LoadScene("HardLevel38");
    }
    public void HardRoom39()
    {
        SceneManager.LoadScene("HardRoom39");
    }
}
