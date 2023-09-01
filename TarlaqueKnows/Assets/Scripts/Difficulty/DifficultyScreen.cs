using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyScreen : MonoBehaviour
{
    public GameObject EasyPanel,NormalPanel,HardPanel;
    void Start()
    {
        if(FinishedLevel.isLevelFinished[14]==false)
        {
            EasyPanel.SetActive(false);
            NormalPanel.SetActive(true);
            HardPanel.SetActive(true);
        }
        else if(FinishedLevel.isLevelFinished[29]==false)
        {
            EasyPanel.SetActive(true);
            NormalPanel.SetActive(false);
            HardPanel.SetActive(true);
        }
        else if(FinishedLevel.isLevelFinished[39]==false)
        {
            EasyPanel.SetActive(true);
            NormalPanel.SetActive(true);
            HardPanel.SetActive(false);            
        }
    }
    
    public void MenuScreen()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void Room()
    {
        if(FinishedLevel.onLevel01==false)
        {            
            SceneManager.LoadScene("Room");    
        }
        else if(FinishedLevel.isLevelFinished[0]==true || FinishedLevel.currentRoom<FinishedLevel.nextRoomIndex)
        {
            SceneManager.LoadScene(FinishedLevel.currentRoom);
        }
        else if(FinishedLevel.onLevel01==true)
        {
            SceneManager.LoadScene("EasyRoom01");
        }
    }
}
