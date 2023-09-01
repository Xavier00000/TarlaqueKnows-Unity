using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR30 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[29]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel30()
    {
        SceneManager.LoadScene("NormalLevel30");
    }
    public void HardRoom31()
    {
        SceneManager.LoadScene("HardRoom31");
    }
}
