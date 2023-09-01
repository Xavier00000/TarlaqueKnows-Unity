using UnityEngine;
using System.Collections;

public class Sound1 : MonoBehaviour
{
    public  AudioClip sfx;
    public  AudioSource audioSource;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("SFX");
        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }        
        DontDestroyOnLoad(this.gameObject);
    }
    
    public void ScreenClicked()
    {
        if(Input.touchCount>0)
        {
            audioSource.Play();
        }
    }
}
