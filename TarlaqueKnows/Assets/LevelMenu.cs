using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
 public void OpenLevel(int MunicipalityId)
    {
        string OpenGame = "Municipality " + MunicipalityId;
        SceneManager.LoadScene(OpenGame);
    }
}
