using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("------- Audio Source -------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------- Audio Clip -------")]
    public AudioClip background;
    public AudioClip btnClick;
    public AudioClip hint;
    public AudioClip levelComplete;
    public AudioClip error;

    [Header("------- Volume Settings -------")]
    [Range(0.0f, 1.0f)]
    public float musicVolume = 1.0f; // Default music volume.
    [Range(0.0f, 1.0f)]
    public float sfxVolume = 1.0f; // Default SFX volume.

    // Use this to ensure there's only one AudioManager in the scene.
    private static AudioManager instance;

    private void Start()
    {
        // Ensure only one instance of AudioManager exists in the scene.
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        // Set this instance as the active AudioManager.
        instance = this;

        // Ensure this AudioManager object isn't destroyed when loading new scenes.
        DontDestroyOnLoad(this.gameObject);

        // Apply the saved volume settings (if any) when the AudioManager starts.
        musicSource.volume = PlayerPrefs.GetFloat("MusicVolume", musicVolume);
        SFXSource.volume = PlayerPrefs.GetFloat("SFXVolume", sfxVolume);

        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void btnPress(AudioClip btnClick)
    {
        SFXSource.clip = btnClick;
        SFXSource.Play();
    }

    public void SetMusicVolume(float volume)
    {
        musicVolume = volume;
        musicSource.volume = volume;

        // Save the music volume setting.
        PlayerPrefs.SetFloat("MusicVolume", volume);
        PlayerPrefs.Save();
    }

    public void SetSFXVolume(float volume)
    {
        sfxVolume = volume;
        SFXSource.volume = volume;

        // Save the SFX volume setting.
        PlayerPrefs.SetFloat("SFXVolume", volume);
        PlayerPrefs.Save();
    }

    private void Update()
    {
        // Check if the background music is not playing, and play it if necessary.
        if (!musicSource.isPlaying)
        {
            musicSource.Play();
        }
    }

    /*private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Handle scene changes here based on the scene and mode if necessary.
        // For example, you can stop the music when transitioning to a specific scene.
        if (scene.buildIndex == 0)
        {
            musicSource.Stop();
        }

        // Reapply the saved volume settings every time a scene is loaded.
        musicSource.volume = PlayerPrefs.GetFloat("MusicVolume", musicVolume);
        SFXSource.volume = PlayerPrefs.GetFloat("SFXVolume", sfxVolume);
    }*/
}
