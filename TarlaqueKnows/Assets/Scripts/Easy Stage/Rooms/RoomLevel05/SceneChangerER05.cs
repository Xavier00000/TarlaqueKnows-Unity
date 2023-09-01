using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER05 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[4]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel05()
    {
        SceneManager.LoadScene("EasyLevel05");
    }
    public void EasyRoom06()
    {
        SceneManager.LoadScene("EasyRoom06");
    }
}
