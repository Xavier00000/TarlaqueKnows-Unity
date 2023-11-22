using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("------- Audio Source -------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] public AudioSource SFXSource;

    [Header("------- Audio Clip -------")]
    public AudioClip background; // Default background music
    public AudioClip anotherBackground; // Another background music for a different scene
    public AudioClip btnClick;
    public AudioClip hint;
    public AudioClip passed;
    public AudioClip levelComplete;
    public AudioClip error;
    public AudioClip reset;
    public AudioClip drag;
    public AudioClip drop;
    public AudioClip pop;

    [Header("------- Volume Settings -------")]
    [Range(0.0f, 1.0f)]
    public float musicVolume = 1.0f; // Default music volume.
    [Range(0.0f, 1.0f)]
    public float sfxVolume = 1.0f; // Default SFX volume.

    // Use this to ensure there's only one AudioManager in the scene.
    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this; // Set the instance to this AudioManager script
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate AudioManager instances
            return;
        }

        DontDestroyOnLoad(gameObject);

        // Apply the saved volume settings (if any) when the AudioManager starts.
        musicSource.volume = PlayerPrefs.GetFloat("MusicVolume", musicVolume);
        SFXSource.volume = PlayerPrefs.GetFloat("SFXVolume", sfxVolume);

        musicSource.clip = background;

        // Check if the musicSource is enabled before trying to play it.
        if (musicSource.enabled)
        {
            musicSource.Play();
        }
    }

    private void Update()
    {
        // Check if the background music is not playing, and play it if necessary.
        if (!musicSource.isPlaying)
        {
            musicSource.Play();
        }
    }

    public void ChangeBackgroundMusic(AudioClip newBackground)
    {
        // Check if the new background music is different from the current one.
        if (musicSource.clip != newBackground)
        {
            musicSource.clip = newBackground;
            musicSource.Play();
        }
        // If it's the same, do nothing and let the current music continue.
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

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Stop SFXSource when a new scene is loaded.
        SFXSource.Stop();

        // Reapply the saved volume settings every time a scene is loaded.
        musicSource.volume = PlayerPrefs.GetFloat("MusicVolume", musicVolume);
        SFXSource.volume = PlayerPrefs.GetFloat("SFXVolume", sfxVolume);

        // Check the name of the loaded scene and change background music accordingly.
        switch (scene.name)
        {
            //QUIZ GAME
            case "EasyLevel01":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel02":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel03":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel04":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel05":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel06":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel07":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel08":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel09":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel10":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel11":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel12":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel13":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel14":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel15":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel16":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel17":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel18":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel19":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel20":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel21":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel22":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel23":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel24":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel25":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel26":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel27":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel28":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel29":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel30":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel31":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel32":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel33":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel34":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel35":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel36":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel37":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel38":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel39":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "EasyLevel40":
                ChangeBackgroundMusic(anotherBackground);
                break;



            //PUZZLE GAME
            case "NormalLevel01 1":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel01 2":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel01 3":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel01 4":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel01 5":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel6":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel6 1":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel6 2":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel6 3":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel7":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel8":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel9":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel10":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel11":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel12":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel13":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel14":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel15":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel16":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel17":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel18":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel19":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel20":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel21":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel22":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel23":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel24":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel25":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel26":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel27":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel28":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel29":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel30":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel31":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel32":
                ChangeBackgroundMusic(anotherBackground);
                break;
            case "NormalLevel33":
                ChangeBackgroundMusic(anotherBackground);
                break;



            // Add more cases for other scenes if needed.
            // case "YourSceneName2":
            //     ChangeBackgroundMusic(anotherBackground2);
            //     break;
            // ...

            default:
                // If the loaded scene doesn't match any case, set the default background music.
                ChangeBackgroundMusic(background);
                break;
        }
    }
}
