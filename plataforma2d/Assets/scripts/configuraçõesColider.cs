using UnityEngine;
using UnityEngine.UI;

public class ConfiguracoesController : MonoBehaviour
{
    public Slider sliderVolume;

    void Start()
    {
        // Define o valor inicial do slider com base no volume atual
        sliderVolume.value = AudioListener.volume;

        // Detecta mudanças no slider
        sliderVolume.onValueChanged.AddListener(AlterarVolume);
    }

    public void AlterarVolume(float valor)
    {
        AudioListener.volume = valor;
    }
}
