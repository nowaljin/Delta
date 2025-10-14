using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject player;
    // 矢の移動速度

    void Start()
    {
        this.player = GameObject.Find("player_0");
    }

    void Update()
    {
       
        //フレームごとに等速で落下させる
        transform.Translate(-0.2f, 0, 0);
            
        //画面外に出たらオブジェクトを破壊する
        if (transform.position.x < -25.0f)
        {
            Destroy(gameObject);
        }

        //当たり判定
        Vector2 p1 = transform.position;    //矢の中心座標
        Vector2 p2 = this.player.transform.position;　// プレイヤの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f; //矢の半径
        float r2 = 1.0f; //プレイヤの半径

        if (d < r1 + r2)
        {
            //監督スクリプトにプレイヤと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();

            //衝突した場合は矢を消す
            Destroy(gameObject);
        }
    }
}