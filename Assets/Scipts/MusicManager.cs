using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource audioSource;  // single AudioSource for all music
    public AudioClip mainMenuClip;
    public AudioClip flappyBirdClip;

    private void Awake()
    {
        // Only one MusicManager in the game
        if (FindObjectsOfType<MusicManager>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    // Call this to play music for a specific scene
    public void PlayMusicForScene(string sceneName)
    {
        if (audioSource == null) return;

        // Stop current music
        audioSource.Stop();

        // Choose clip depending on scene
        if (sceneName == "MainMenu" && mainMenuClip != null)
        {
            audioSource.clip = mainMenuClip;
        }
        else if (sceneName == "FlappyBird" && flappyBirdClip != null)
        {
            audioSource.clip = flappyBirdClip;
        }
        else
        {
            // No music for other scenes
            return;
        }

        audioSource.loop = true;
        audioSource.Play();
    }

    public void StopMusic()
    {
        if (audioSource != null && audioSource.isPlaying)
            audioSource.Stop();
    }
}