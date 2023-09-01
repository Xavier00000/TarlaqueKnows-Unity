using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER07 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[6]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel07()
    {
        SceneManager.LoadScene("EasyLevel07");
    }
    public void EasyRoom08()
    {
        SceneManager.LoadScene("EasyRoom08");
    }
}
