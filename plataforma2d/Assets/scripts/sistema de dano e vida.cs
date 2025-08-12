using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public PlayerStats playerStats;
    public int danoInimigo = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Inimigo"))
        {
            playerStats.PerderVida(danoInimigo);
        }
    }
}