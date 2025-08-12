using UnityEngine;
using UnityEngine.UI;

public class ExtrasManager : MonoBehaviour
{
    [Header("Galeria de Imagens")]
    public Image imagemGaleria;     // Componente Image do painel
    public Sprite[] imagens;        // Lista de imagens da galeria
    private int indiceImagem = 0;   // Índice da imagem atual

    void Start()
    {
        // Mostra a primeira imagem ao iniciar
        if (imagens.Length > 0 && imagemGaleria != null)
            imagemGaleria.sprite = imagens[indiceImagem];
    }

    public void ProximaImagem()
    {
        if (imagens.Length == 0) return;
        indiceImagem = (indiceImagem + 1) % imagens.Length;
        imagemGaleria.sprite = imagens[indiceImagem];
    }

    public void ImagemAnterior()
    {
        if (imagens.Length == 0) return;
        indiceImagem = (indiceImagem - 1 + imagens.Length) % imagens.Length;
        imagemGaleria.sprite = imagens[indiceImagem];
    }
}