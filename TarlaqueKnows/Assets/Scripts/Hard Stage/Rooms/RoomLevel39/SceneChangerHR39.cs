using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerHR39 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {        
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[38]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void HardLevel39()
    {
        SceneManager.LoadScene("HardLevel39");
    }
    public void HardRoom40()
    {
        SceneManager.LoadScene("HardRoom40");
    }
}
