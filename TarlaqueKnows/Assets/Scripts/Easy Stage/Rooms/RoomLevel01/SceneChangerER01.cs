using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChangerER01 : MonoBehaviour
{
    public Animator Animation;
    public Text Dialogue;
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[0]==true)
        {
            Animation.Play("Finished_Level");
            Dialogue.text="Yes! We solved it! Ok, time to go to the next level!";
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel01()
    {
        SceneManager.LoadScene("EasyLevel01");
    }
    public void ExitNextScene()
    {
        Animation.Play("Exit_Room");
    }
    public void EasyRoom02()
    {
        SceneManager.LoadScene("EasyRoom02");
    }
}
