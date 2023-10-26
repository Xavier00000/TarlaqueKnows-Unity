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

    private void Update()
    {
        // Check if the background music is not playing, and play it if necessary.
        if (!musicSource.isPlaying)
        {
            musicSource.Play();
        }
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
        // Handle scene changes here based on the scene and mode if necessary.
        // For example, you can stop the music when transitioning to a specific scene.
        if (scene.buildIndex == 1)
        {
            musicSource.Stop();
        }
    }
}
