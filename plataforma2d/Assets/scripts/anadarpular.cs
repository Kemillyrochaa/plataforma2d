using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float velocidade = 5f;
    public float forcaPulo = 10f;
    private Rigidbody2D rb;
    private bool estaNoChao = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimento = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movimento * velocidade, rb.velocity.y);

        if (estaNoChao && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, forcaPulo), ForceMode2D.Impulse);
            estaNoChao = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            estaNoChao = true;
        }
    }
}