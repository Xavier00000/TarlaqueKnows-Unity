using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadScene02()
    {
        SceneManager.LoadScene("LoadScene2");
    }
    public void MenuScreen()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
