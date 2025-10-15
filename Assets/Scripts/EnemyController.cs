using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject player;
    

    void Start()
    {
        this.player = GameObject.Find("player_0");
    }

    void Update()
    {
       
        
        transform.Translate(-0.2f, 0, 0);
            
       
        if (transform.position.x < -25.0f)
        {
            Destroy(gameObject);
        }

        
        Vector2 p1 = transform.position;    
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f; 
        float r2 = 1.0f; 

        if (d < r1 + r2)
        {
            
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();

            
            Destroy(gameObject);
        }
    }
}