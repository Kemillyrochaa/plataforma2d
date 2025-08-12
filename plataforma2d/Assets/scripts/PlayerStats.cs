using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int vidas = 3;         // Número inicial de vidas
    public float energia = 100f;  // Energia inicial (0 a 100)
    private int maxVidas = 5;

    public void PerderVida(int quantidade)
    {
        vidas = Mathf.Max(vidas - quantidade, 0);
    }

    public void GanharVida(int quantidade)
    {
        vidas = Mathf.Min(vidas + quantidade, maxVidas);
    }

    public void AlterarEnergia(float quantidade)
    {
        energia = Mathf.Clamp(energia + quantidade, 0f, 100f);
    }

    void Update()
    {
        // Diminuir vida
        if (Input.GetKeyDown(KeyCode.L))
        {
            PerderVida(1);
        }

        // Aumentar vida
        if (Input.GetKeyDown(KeyCode.K))
        {
            GanharVida(1);
        }

        // Diminuir energia
        if (Input.GetKeyDown(KeyCode.E))
        {
            AlterarEnergia(-10f);
        }

        // Aumentar energia
        if (Input.GetKeyDown(KeyCode.R))
        {
            AlterarEnergia(10f);
        }
    }
}