using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LooseSceneManager : MonoBehaviour
{
    public Text scoreText;
    public AudioSource loseSound;

private void Start()
{
    // Stop any music
    MusicManager music = FindObjectOfType<MusicManager>();
    if (music != null)
        music.StopMusic();

    scoreText.text = "Score: " + GameManager.finalScore;

    if (loseSound != null)
        loseSound.Play();
}

    public void PlayAgain()
    {
        SceneManager.LoadScene("FlappyBird");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit clicked");
    }

     public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}