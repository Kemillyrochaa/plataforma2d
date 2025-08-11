using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject painelConfiguracoes;
    public GameObject painelCreditos;
    public GameObject painelExtras;

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
}