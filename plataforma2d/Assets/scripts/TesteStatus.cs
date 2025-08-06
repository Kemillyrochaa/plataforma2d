using UnityEngine;

public class TesteStatus : MonoBehaviour
{
    public PlayerStatus playerStatus;

    void Update()
    {
        // Pressione a tecla "H" para perder 1 vida
        if (Input.GetKeyDown(KeyCode.H))
        {
            playerStatus.vidas = Mathf.Max(0, playerStatus.vidas - 1);
        }

        // Pressione a tecla "J" para recuperar 1 vida
        if (Input.GetKeyDown(KeyCode.J))
        {
            playerStatus.vidas = Mathf.Min(3, playerStatus.vidas + 1);
        }

        // Pressione a tecla "E" para gastar energia
        if (Input.GetKey(KeyCode.E))
        {
            playerStatus.energia = Mathf.Max(0, playerStatus.energia - 20 * Time.deltaTime);
        }

        // Pressione a tecla "R" para recuperar energia
        if (Input.GetKey(KeyCode.R))
        {
            playerStatus.energia = Mathf.Min(100, playerStatus.energia + 30 * Time.deltaTime);
        }
    }
}