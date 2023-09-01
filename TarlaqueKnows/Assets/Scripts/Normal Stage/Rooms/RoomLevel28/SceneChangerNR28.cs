using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerNR28 : MonoBehaviour
{
    public Animator Animation;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[27]==true)
        {
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void NormalLevel28()
    {
        SceneManager.LoadScene("NormalLevel28");
    }
    public void NormalRoom29()
    {
        SceneManager.LoadScene("NormalRoom29");
    }
}
