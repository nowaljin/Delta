using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;
    float spawnInterval = 1.0f;
    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            timer = 0f;

            float randomY = Random.Range(-4.0f, 4.0f);

            // カメラ右端の外側に敵を生成
            Vector3 camRight = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, 0.5f, 0));
            float spawnX = camRight.x;

            Vector3 spawnPosition = new Vector3(spawnX, randomY, 0f);
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
