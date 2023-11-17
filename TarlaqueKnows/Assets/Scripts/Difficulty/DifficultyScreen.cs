using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyScreen : MonoBehaviour
{
    public GameObject TarlacCity, Bamban, SanManuel, Conception, Gerona, Anao, SanJose, Victoria, Mayantoc;
    void Start()
    {




        if (FinishedLevel.isLevelFinished[0] == false)
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
        else if (FinishedLevel.isLevelFinished[5] == false)
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
        else if (FinishedLevel.isLevelFinished[9] == false)
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
        else if (FinishedLevel.isLevelFinished[13] == false)
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
        else if (FinishedLevel.isLevelFinished[17] == false)
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
        else if (FinishedLevel.isLevelFinished[21] == false)
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
        else if (FinishedLevel.isLevelFinished[25] == false)
        {
            TarlacCity.SetActive(false);
            Bamban.SetActive(false);
            SanManuel.SetActive(false);
            Conception.SetActive(false);
            Gerona.SetActive(false);
            Anao.SetActive(false);
            SanJose.SetActive(true);
            Victoria.SetActive(true);
        }
        else if (FinishedLevel.isLevelFinished[29] == false)
        {
            TarlacCity.SetActive(false);
            Bamban.SetActive(false);
            SanManuel.SetActive(false);
            Conception.SetActive(false);
            Gerona.SetActive(false);
            Anao.SetActive(false);
            SanJose.SetActive(false);
            Victoria.SetActive(true);
        }
        else if (FinishedLevel.isLevelFinished[33] == false)
        {
            TarlacCity.SetActive(false);
            Bamban.SetActive(false);
            SanManuel.SetActive(false);
            Conception.SetActive(false);
            Gerona.SetActive(false);
            Anao.SetActive(false);
            SanJose.SetActive(false);
            Victoria.SetActive(false);
            Mayantoc.SetActive(true);
        }
        else if (FinishedLevel.isLevelFinished[37] == false)
        {
            TarlacCity.SetActive(false);
            Bamban.SetActive(false);
            SanManuel.SetActive(false);
            Conception.SetActive(false);
            Gerona.SetActive(false);
            Anao.SetActive(false);
            SanJose.SetActive(false);
            Victoria.SetActive(false);
            Mayantoc.SetActive(false);
        }
    }


}