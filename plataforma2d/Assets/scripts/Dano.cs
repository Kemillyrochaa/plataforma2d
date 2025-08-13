using System;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public string tagDoObjeto;
    public int dano = 1;
    public void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == tagDoObjeto)
        {
            int vida = colisao.gameObject.GetComponent<PlayerStats>().getVida();
            colisao.gameObject.GetComponent<PlayerStats>().setVida(vida-dano);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}