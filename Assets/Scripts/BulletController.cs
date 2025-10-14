
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;


    void Update()
    {
        // �e���E�����ɐi�߂�iX���j
        transform.Translate(speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����폜
        if (transform.position.x > 10000.0f)  // �K�v�ɉ����ċ�������
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
