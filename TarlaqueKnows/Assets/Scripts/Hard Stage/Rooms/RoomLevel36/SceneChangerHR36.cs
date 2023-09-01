using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerHR36 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {        
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[35]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void HardLevel36()
    {
        SceneManager.LoadScene("HardLevel36");
    }
    public void HardRoom37()
    {
        SceneManager.LoadScene("HardRoom37");
    }
}
