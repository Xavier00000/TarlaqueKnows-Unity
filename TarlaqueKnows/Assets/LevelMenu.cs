using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
 public void OpenLevel(int TarlacCityId)
    {
        string OpenGame = "Tarlac City" + TarlacCityId;
        SceneManager.LoadScene(OpenGame);
    }
}
