using UnityEngine;

public class ItemColetavel : MonoBehaviour
{
    public enum TipoItem { VidaExtra, Energia }
    public TipoItem tipo;
    public int vidaExtra = 1;
    public float energiaRecuperada = 20f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerStats player = collision.GetComponent<PlayerStats>();
            if (player != null)
            {
                if (tipo == TipoItem.VidaExtra)
                {
                    player.GanharVida(vidaExtra);
                }
                else if (tipo == TipoItem.Energia)
                {
                    player.AlterarEnergia(energiaRecuperada);
                }
            }
            Destroy(gameObject);
        }
    }
}