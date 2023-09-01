using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER11 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[10]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel11()
    {
        SceneManager.LoadScene("EasyLevel11");
    }
    public void EasyRoom12()
    {
        SceneManager.LoadScene("EasyRoom12");
    }
}
