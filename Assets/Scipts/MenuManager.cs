using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private void Start()
    {
        MusicManager music = FindObjectOfType<MusicManager>();
        if (music != null)
        {
            music.PlayMusicForScene("MainMenu");
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("FlappyBird");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}