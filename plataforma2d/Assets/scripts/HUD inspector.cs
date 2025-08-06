// HUDController.cs
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public PlayerStatus playerStatus;
    public Slider barraVidas;
    public Slider barraEnergia;

    void Update()
    {
        barraVidas.value = playerStatus.vidas;
        barraEnergia.value = playerStatus.energia;
    }
}