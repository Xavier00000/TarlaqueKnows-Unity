using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour
{
    public  AudioClip music;
    public  AudioSource audioSource;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }        
        DontDestroyOnLoad(this.gameObject);
    }
}
