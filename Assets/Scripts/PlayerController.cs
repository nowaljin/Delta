using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody2D rb;
    public GameObject bulletPrefab;

    public AudioClip shootSound; // Inspectorで設定する
    private AudioSource audioSource;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(bulletPrefab, transform.position , Quaternion.identity);

                // サウンド再生
                if (shootSound != null)
                {
                    audioSource.PlayOneShot(shootSound);
                }
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up * 20f); // 上に加速
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
        }

            if (transform.position.y > 35f || transform.position.y < -18f)
            {
                GameDirector.gameClear = false; // ゲームオーバー扱いにする
                SceneManager.LoadScene("GameEnd");
            }
        }
}
    }
