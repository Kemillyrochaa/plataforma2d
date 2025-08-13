using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public float speed = 3f;

    void Update()
    {
        if (player != null)
        {
            // Direção do inimigo em direção ao jogador
            Vector3 direction = (player.position - transform.position).normalized;

            // Move o inimigo na direção do jogador
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}