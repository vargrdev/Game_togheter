using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Removi o [SerializeField]. Agora a caixinha some do Unity e ele usa o que está aqui.
    public float velocidade = 8f;
    public float forcaPulo = 1f;

    private Rigidbody2D rb;
    private bool estaNoChao;
    private float moveInput;

    // Igual ao CREATE do Game Maker
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Igual ao STEP do Game Maker
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && estaNoChao)
        {
        
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaPulo);
            estaNoChao = false; 
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveInput * velocidade, rb.linearVelocity.y);
    }

    private void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("fool"))
        {
            estaNoChao = true;
        }
    }
}