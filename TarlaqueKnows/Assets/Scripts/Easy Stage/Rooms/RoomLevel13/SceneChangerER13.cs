using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER13 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[12]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel13()
    {
        SceneManager.LoadScene("EasyLevel13");
    }
    public void EasyRoom14()
    {
        SceneManager.LoadScene("EasyRoom14");
    }
}
