using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyScreenPuzzle : MonoBehaviour
{
    public GameObject TarlacCity,Bamban,SanManuel, Conception, Gerona, Anao, SanJose, Victoria;
    void Start()
    {
        if(FinishedLevelP.isLevelFinished[5]==false)
        {
            TarlacCity.SetActive(false);
            Bamban.SetActive(true);
            SanManuel.SetActive(true);
            Conception.SetActive(true);
            Gerona.SetActive(true);
            Anao.SetActive(true);
            SanJose.SetActive(true);
            Victoria.SetActive(true);
        }
        else if(FinishedLevelP.isLevelFinished[9]==false)
        {
            TarlacCity.SetActive(false);
            Bamban.SetActive(false);
            SanManuel.SetActive(true);
            Conception.SetActive(true);
            Gerona.SetActive(true);
            Anao.SetActive(true);
            SanJose.SetActive(true);
            Victoria.SetActive(true);
        }
        else if(FinishedLevelP.isLevelFinished[13]==false)
        {
            TarlacCity.SetActive(false);
            Bamban.SetActive(false);
            SanManuel.SetActive(false);
            Conception.SetActive(true);
            Gerona.SetActive(true);
            Anao.SetActive(true);
            SanJose.SetActive(true);
            Victoria.SetActive(true);
        }
        else if (FinishedLevelP.isLevelFinished[17] == false)
        {
            TarlacCity.SetActive(false);
            Bamban.SetActive(false);
            SanManuel.SetActive(false);
            Conception.SetActive(false);
            Gerona.SetActive(true);
            Anao.SetActive(true);
            SanJose.SetActive(true);
            Victoria.SetActive(true);
        }
        else if (FinishedLevelP.isLevelFinished[21] == false)
        {
            TarlacCity.SetActive(false);
            Bamban.SetActive(false);
            SanManuel.SetActive(false);
            Conception.SetActive(false);
            Gerona.SetActive(false);
            Anao.SetActive(true);
            SanJose.SetActive(true);
            Victoria.SetActive(true);
        }
        else if (FinishedLevelP.isLevelFinished[25] == false)
        {
            TarlacCity.SetActive(false);
            Bamban.SetActive(false);
            SanManuel.SetActive(false);
            Conception.SetActive(false);
            Gerona.SetActive(false);
            Anao.SetActive(false) ;
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
        if(FinishedLevelP.onLevel01==false)
        {            
            SceneManager.LoadScene("Room");    
        }
        else if(FinishedLevelP.isLevelFinished[6]==true || FinishedLevelP.currentRoom<FinishedLevelP.nextRoomIndex)
        {
            SceneManager.LoadScene(FinishedLevelP.currentRoom);
        }
        else if(FinishedLevelP.onLevel01==true)
        {
            SceneManager.LoadScene("EasyLevel01");
        }
    }
}
