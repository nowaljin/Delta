using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    public Text GameText;
    public Text ScoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        if (GameDirector.gameClear == false)
        {
            GameText.text = "Game Over!";
        }
        else if (GameDirector.gameClear == true)
        {
            GameText.text = "Game Clear!";
        }
        ScoreText.text = "Score :" + GameDirector.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ReStart()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Title()
    {
        SceneManager.LoadScene("Title");
    }
}
