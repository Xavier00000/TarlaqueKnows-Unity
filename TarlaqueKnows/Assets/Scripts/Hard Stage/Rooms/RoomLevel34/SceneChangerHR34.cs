using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerHR34 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {        
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[33]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void HardLevel34()
    {
        SceneManager.LoadScene("HardLevel34");
    }
    public void HardRoom35()
    {
        SceneManager.LoadScene("HardRoom35");
    }
}
