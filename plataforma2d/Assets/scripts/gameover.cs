using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject painelGameOver;
    public PlayerStats player;

    void Update()
    {
        if (player.vidas <= 0)
        {
            painelGameOver.SetActive(true);
            Time.timeScale = 0f; // pausa o jogo
        }
    }

    public void ReiniciarJogo()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void VoltarMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}