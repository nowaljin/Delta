using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float minX = -5f; // Kamera sol sınır
    public float maxX = 5f;  // Kamera sağ sınır
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (player == null) return;

        // Player'ın X pozisyonunu sınırla
        float targetX = Mathf.Clamp(player.position.x, minX, maxX);

        // Yumuşak takip
        Vector3 targetPos = new Vector3(targetX, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothSpeed * Time.deltaTime);
    }
}