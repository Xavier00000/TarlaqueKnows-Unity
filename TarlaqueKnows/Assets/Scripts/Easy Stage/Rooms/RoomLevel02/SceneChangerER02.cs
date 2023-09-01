using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER02 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[1]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel02()
    {
        SceneManager.LoadScene("EasyLevel02");
    }
    public void EasyRoom03()
    {
        SceneManager.LoadScene("EasyRoom03");
    }
}
