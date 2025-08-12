using UnityEngine;
using UnityEngine.UI;

public class UIStats : MonoBehaviour
{
    public PlayerStats player;        // Referência ao Player
    public Slider barraVidas;         // Slider para Vidas
    public Slider barraEnergia;       // Slider para Energia

    void Start()
    {
        // Define os valores máximos das barras
        barraVidas.maxValue = 5;  // Supondo que o máximo seja 5 vidas
        barraEnergia.maxValue = 100f;
    }

    void Update()
    {
        barraVidas.value = player.vidas;
        barraEnergia.value = player.energia;
    }
}