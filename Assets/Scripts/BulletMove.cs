using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed = 0.05f; // ’e‚ÌˆÚ“®‘¬“x

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right*speed * Time.deltaTime);
    }
}
