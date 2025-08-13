using UnityEngine;
using UnityEngine.UI;


public class BarraDeVida : MonoBehaviour
{
    
    public PlayerStats personagem;
    [SerializeField]
    private int vidasRestantes = 0;
    [SerializeField]
    private int energiasRestantes = 0;
    
    public Slider slider_vidasRestantes;
    public Slider slider_energiasRestantes;
    void Start()
    {
        //buscar o objeto jogador
        if (personagem == null)
        {
            //personagem = GameObject.Find("Jogador").GetComponent<Jogador>();
            personagem = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();
        }

        if (personagem != null)
        {
            if (slider_vidasRestantes != null)
            {
                slider_vidasRestantes.minValue = 0;
                slider_vidasRestantes.maxValue = personagem.getVida();
            }

            if (slider_energiasRestantes != null)
            {
                slider_energiasRestantes.minValue = 0;
                slider_energiasRestantes.maxValue = personagem.getEnergia();
            }
        }


        // vidasRestantes = jogador.getVida();
        //energiasRestantes = jogador.getEnergia();
    }

    
    void Update()
    {

        if (slider_vidasRestantes != null)
        {

            vidasRestantes = personagem.getVida();
            slider_vidasRestantes.value = vidasRestantes;
        }

        if (slider_energiasRestantes != null)
        {
            energiasRestantes = personagem.getEnergia();
            slider_energiasRestantes.value = energiasRestantes;
        }

    }
}