using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open : MonoBehaviour
{
    public GameObject TarlacCity, Bamban, panel;
    public void ShowBamban()
    {

        Bamban.SetActive(true);
    }
    public void ShowTarlac()
    {
        TarlacCity.SetActive(true);

    }
}
