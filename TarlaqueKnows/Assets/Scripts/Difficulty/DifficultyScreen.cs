using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyScreen : MonoBehaviour
{
    public GameObject TarlacCity,Bamban,SanManuel, Conception, Ramos, Anao, SanJose, Victoria;
    void Start()
    {
        if(FinishedLevel.isLevelFinished[5]==false)
        {
            TarlacCity.SetActive(false);
            Bamban.SetActive(true);
            SanManuel.SetActive(true);
            Conception.SetActive(true);
            Ramos.SetActive(true);
            Anao.SetActive(true);
            SanJose.SetActive(true);
            Victoria.SetActive(true);
        }
        else if(FinishedLevel.isLevelFinished[9]==false)
        {
            TarlacCity.SetActive(false);
            Bamban.SetActive(false);
            SanManuel.SetActive(true);
            Conception.SetActive(true);
            Ramos.SetActive(true);
            Anao.SetActive(true);
            SanJose.SetActive(true);
            Victoria.SetActive(true);
        }
        else if(FinishedLevel.isLevelFinished[13]==false)
        {
            TarlacCity.SetActive(false);
            Bamban.SetActive(false);
            SanManuel.SetActive(false);
            Conception.SetActive(true);
            Ramos.SetActive(true);
            Anao.SetActive(true);
            SanJose.SetActive(true);
            Victoria.SetActive(true);
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
        else if(FinishedLevel.isLevelFinished[6]==true || FinishedLevel.currentRoom<FinishedLevel.nextRoomIndex)
        {
            SceneManager.LoadScene(FinishedLevel.currentRoom);
        }
        else if(FinishedLevel.onLevel01==true)
        {
            SceneManager.LoadScene("EasyLevel01");
        }
    }
}
