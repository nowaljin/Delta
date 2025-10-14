using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject player;
    // ��̈ړ����x

    void Start()
    {
        this.player = GameObject.Find("player_0");
    }

    void Update()
    {
       
        //�t���[�����Ƃɓ����ŗ���������
        transform.Translate(-0.2f, 0, 0);
            
        //��ʊO�ɏo����I�u�W�F�N�g��j�󂷂�
        if (transform.position.x < -25.0f)
        {
            Destroy(gameObject);
        }

        //�����蔻��
        Vector2 p1 = transform.position;    //��̒��S���W
        Vector2 p2 = this.player.transform.position;�@// �v���C���̒��S���W
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f; //��̔��a
        float r2 = 1.0f; //�v���C���̔��a

        if (d < r1 + r2)
        {
            //�ēX�N���v�g�Ƀv���C���ƏՓ˂������Ƃ�`����
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();

            //�Փ˂����ꍇ�͖������
            Destroy(gameObject);
        }
    }
}