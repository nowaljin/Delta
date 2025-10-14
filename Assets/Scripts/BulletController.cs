
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;


    void Update()
    {
        // 弾を右方向に進める（X軸）
        transform.Translate(speed * Time.deltaTime, 0, 0);

        // 画面外に出たら削除
        if (transform.position.x > 10000.0f)  // 必要に応じて距離調整
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "enemyPrefab(Clone)")
        {
            GameDirector.score += 10;
            GameDirector.scoreText.text = "Score : " + GameDirector.score.ToString("");

            GameObject directorObj = GameObject.Find("GameDirector");
            if (directorObj != null)
            {
                GameDirector director = directorObj.GetComponent<GameDirector>();
                director.PlayEnemyDeathSound();
            }

            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }

}
