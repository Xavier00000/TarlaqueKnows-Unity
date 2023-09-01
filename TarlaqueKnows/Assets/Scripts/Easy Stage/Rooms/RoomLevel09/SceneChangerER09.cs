using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER09 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[8]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel09()
    {
        SceneManager.LoadScene("EasyLevel09");
    }
    public void EasyRoom10()
    {
        SceneManager.LoadScene("EasyRoom10");
    }
}
