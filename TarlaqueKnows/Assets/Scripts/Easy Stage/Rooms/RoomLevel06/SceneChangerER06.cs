using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER06 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[5]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel06()
    {
        SceneManager.LoadScene("EasyLevel06");
    }
    public void EasyRoom07()
    {
        SceneManager.LoadScene("EasyRoom07");
    }
}
