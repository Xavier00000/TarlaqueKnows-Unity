using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerHR33 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {        
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[32]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void HardLevel33()
    {
        SceneManager.LoadScene("HardLevel33");
    }
    public void HardRoom34()
    {
        SceneManager.LoadScene("HardRoom34");
    }
}
