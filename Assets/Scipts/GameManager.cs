using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;

    public static int finalScore;

    private int score;
    public AudioSource winSound;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    private void Start()
    {
        Play(); // start game automatically
    }

public void Play()
{
    score = 0;
    scoreText.text = score.ToString();
    Time.timeScale = 1f;
    player.enabled = true;

    Pipes[] pipes = FindObjectsByType<Pipes>(FindObjectsSortMode.None);
    for (int i = 0; i < pipes.Length; i++)
        Destroy(pipes[i].gameObject);

    // Play FlappyBird music
    MusicManager music = FindObjectOfType<MusicManager>();
    if (music != null)
        music.PlayMusicForScene("FlappyBird");
}
    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        finalScore = score; // save score
        Time.timeScale = 1f;
        SceneManager.LoadScene("LooseScene");
    }

    public void IncreaseScore()
{
    score++;
    scoreText.text = score.ToString();

    if (winSound != null)
    {
        winSound.PlayOneShot(winSound.clip);
    }
}
}