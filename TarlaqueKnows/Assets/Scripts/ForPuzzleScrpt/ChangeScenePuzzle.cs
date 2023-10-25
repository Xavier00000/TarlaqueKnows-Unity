using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenePuzzle : MonoBehaviour
{
    public void BackToStartScene()
    {
        SceneManager.LoadScene("Start Scene");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

   



    //Level scene Puzzle 1-6
    public void MoveToScene1()
    {
        SceneManager.LoadScene("NormalLevel01");
    }
    public void MoveToScene2()
    {
        SceneManager.LoadScene("NormalLevel02");
    }
    public void MoveToScene3()
    {
        SceneManager.LoadScene("NormalLevel03");
    }
    public void MoveToScene4()
    {
        SceneManager.LoadScene("NormalLevel04");
    }
    public void MoveToScene5()
    {
        SceneManager.LoadScene("NormalLevel05");
    }
    public void MoveToScene6()
    {
        SceneManager.LoadScene("NormalLevel06");
    }



    //Level scene Puzzle 7-10
    public void MoveToScene7()
    {
        SceneManager.LoadScene("EasyLevel07");
    }
    public void MoveToScene8()
    {
        SceneManager.LoadScene("EasyLevel08");
    }
    public void MoveToScene9()
    {
        SceneManager.LoadScene("EasyLevel09");
    }
    public void MoveToScene10()
    {
        SceneManager.LoadScene("EasyLevel10");
    }

    //Level scene Puzzle 11-14
    public void MoveToScene11()
    {
        SceneManager.LoadScene("EasyLevel11");
    }
    public void MoveToScene12()
    {
        SceneManager.LoadScene("EasyLevel12");
    }
    public void MoveToScene13()
    {
        SceneManager.LoadScene("EasyLevel13");
    }
    public void MoveToScene14()
    {
        SceneManager.LoadScene("EasyLevel14");
    }

    //Level scene Puzzle 15-18
    public void MoveToScene15()
    {
        SceneManager.LoadScene("EasyLevel15");
    }
    public void MoveToScene16()
    {
        SceneManager.LoadScene("EasyLevel16");
    }
    public void MoveToScene17()
    {
        SceneManager.LoadScene("EasyLevel17");
    }
    public void MoveToScene18()
    {
        SceneManager.LoadScene("EasyLevel18");
    }



  
}

