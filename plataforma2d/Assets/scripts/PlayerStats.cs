using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    private int vida;
    [SerializeField]
    private int energia;
    [SerializeField]
    private float velocidade;

    public int getVida()
    {
        return this.vida;
    }

    public void setVida(int vida)
    {
        this.vida = vida;
    }
    
    public int getEnergia()
    {
        return this.energia;
    }

    public void setEnergia(int energia)
    {
        this.energia = energia;
    }

    public float getVelocidade()
    {
        return this.velocidade;
    }

    public void setVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}