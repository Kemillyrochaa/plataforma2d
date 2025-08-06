using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject painelConfiguracoes;
    public GameObject painelCreditos;

    // Botão "Nova Partida"
    public void IniciarJogo()
    {
        SceneManager.LoadScene("Jogo");
    }

    // Botão "Configurações"
    public void AbrirConfiguracoes()
    {
        painelConfiguracoes.SetActive(true);
    }

    public void FecharConfiguracoes()
    {
        painelConfiguracoes.SetActive(false);
    }

    // Botão "Créditos"
    public void MostrarCreditos()
    {
        painelCreditos.SetActive(true);
    }

    public void FecharCreditos()
    {
        painelCreditos.SetActive(false);
    }

    // Botão "Sair"
    public void SairJogo()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}