using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER08 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[7]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel08()
    {
        SceneManager.LoadScene("EasyLevel08");
    }
    public void EasyRoom09()
    {
        SceneManager.LoadScene("EasyRoom09");
    }
}
