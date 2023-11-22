using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerER01 : MonoBehaviour
{
    public Animator Animation;
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    void Start()
    {
        FinishedLevel.currentRoom=SceneManager.GetActiveScene().buildIndex;
        if(FinishedLevel.isLevelFinished[5]==true)
        {
            audioManager.PlaySFX(audioManager.levelComplete);
            Animation.Play("Finished_Level");
        }
        else
        {
            Animation.Play("Fade_In");
        }
        
    }
    public void EasyLevel15()
    {
        SceneManager.LoadScene("Start Scene");
    }
    public void NormalRoom16()
    {
        SceneManager.LoadScene("Start Scene");
    }
}
