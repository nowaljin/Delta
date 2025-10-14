using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public AudioClip enemyDeathSound;
    private AudioSource audioSource;

    GameObject hpGuage;
    public static bool gameClear = false;
    public Text timerText;
    public static Text scoreText;
    public float timeLimit = 60f;
    private float timeRemaining;
    public static int score = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
        timeRemaining = timeLimit;
        this.hpGuage = GameObject.Find("hpGuage");
        GameDirector.scoreText = GameObject.Find("Score").GetComponent<Text>();
    }

    private void Update()
    {
        if (timeRemaining > 0f)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Time : " + timeRemaining.ToString("F2") + "s";

            if (timeRemaining <= 0f)
            {
                // タイムアップ時の処理
                gameClear = true;
                SceneManager.LoadScene("GameEnd");
            }
        }
    }

    // Update is called once per frame
    public void DecreaseHP()
    {
        Image img = this.hpGuage.GetComponent<Image>();
        img.fillAmount -= 0.1f;

        // HPが0以下になったらシーンを変更
        if (img.fillAmount <= 0f)
        {
            SceneManager.LoadScene("GameEnd");
        }
    }

    public void PlayEnemyDeathSound()
    {
        if (enemyDeathSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(enemyDeathSound);
        }
    }

}