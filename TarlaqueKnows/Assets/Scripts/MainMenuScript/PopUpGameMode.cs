using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpGameMode : MonoBehaviour
{
    public GameObject Game;

    public void ShowGame()
    {
        Game.SetActive(true);

    }
    public void CancelBack()
    {
        Game.SetActive(false);
    }
}
