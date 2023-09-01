using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR19 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[18]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel19()
    {
        SceneManager.LoadScene("NormalLevel19");
    }
    public void NormalRoom20()
    {
        SceneManager.LoadScene("NormalRoom20");
    }
}
