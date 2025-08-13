using UnityEngine;

public partial class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;

    public PlayerController(Rigidbody2D rb)
    {
        this.rb = rb;
        this.rb = rb;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Captura o input do teclado
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        // Move o jogador
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}