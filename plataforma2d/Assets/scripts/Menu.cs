using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [Header("Painéis")]
    public GameObject painelConfiguracoes;
    public GameObject painelCreditos;
    public GameObject painelExtras;

    [Header("Configurações")]
    public Slider sliderVolume;
    public Slider sliderBrilho; // Vídeo
    public Slider sliderSensibilidade; // Controles

    private float brilho = 1f;
    private float sensibilidade = 1f;

    void Start()
    {
        // Volume
        if (sliderVolume != null)
        {
            sliderVolume.minValue = 0f;
            sliderVolume.maxValue = 1f;
            sliderVolume.value = AudioListener.volume;
            sliderVolume.onValueChanged.AddListener(AlterarVolume);
        }

        // Brilho
        if (sliderBrilho != null)
        {
            sliderBrilho.minValue = 0.5f;
            sliderBrilho.maxValue = 1.5f;
            sliderBrilho.value = brilho;
            sliderBrilho.onValueChanged.AddListener(AlterarBrilho);
        }

        // Sensibilidade
        if (sliderSensibilidade != null)
        {
            sliderSensibilidade.minValue = 0.5f;
            sliderSensibilidade.maxValue = 2f;
            sliderSensibilidade.value = sensibilidade;
            sliderSensibilidade.onValueChanged.AddListener(AlterarSensibilidade);
        }
    }

    public void NovaPartida()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void Configuracoes()
    {
        painelConfiguracoes.SetActive(true);
        painelCreditos.SetActive(false);
        painelExtras.SetActive(false);
    }

    public void Creditos()
    {
        painelCreditos.SetActive(true);
        painelConfiguracoes.SetActive(false);
        painelExtras.SetActive(false);
    }

    public void Extras()
    {
        painelExtras.SetActive(true);
        painelConfiguracoes.SetActive(false);
        painelCreditos.SetActive(false);
    }

    public void FecharTudo()
    {
        painelConfiguracoes.SetActive(false);
        painelCreditos.SetActive(false);
        painelExtras.SetActive(false);
    }

    public void AlterarVolume(float valor)
    {
        AudioListener.volume = valor;
    }

    public void AlterarBrilho(float valor)
    {
        brilho = valor;
        // Ajusta brilho multiplicando pela cor do ambiente
        RenderSettings.ambientLight = Color.white * brilho;
    }

    public void AlterarSensibilidade(float valor)
    {
        sensibilidade = valor;
        // Aqui você ajustaria a sensibilidade do controle do jogador
        Debug.Log("Sensibilidade alterada para: " + sensibilidade);
    }
}
