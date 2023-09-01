using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerHR37 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {        
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[36]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void HardLevel37()
    {
        SceneManager.LoadScene("HardLevel37");
    }
    public void HardRoom38()
    {
        SceneManager.LoadScene("HardRoom38");
    }
}
