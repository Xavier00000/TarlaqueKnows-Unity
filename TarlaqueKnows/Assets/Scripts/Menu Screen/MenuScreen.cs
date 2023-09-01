using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScreen : MonoBehaviour
{   
    public GameObject noteBox;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void DifficultyScene()
    {
        if(FinishedLevel.isLevelFinished[39]==true)
        {
            noteBox.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("DifficultyScene");
        }
    }
    public void CloseNoteBox()
    {
        noteBox.SetActive(false);
    }
    public void QuitApplication()
    {
        Application.Quit();
    }
    
}
