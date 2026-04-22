using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D box;
    private Vector2 playerDirection;
    public Animator animasi;

    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    private bool isGrounded;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float JumpPower = 10f;

    public void Movement(InputAction.CallbackContext ctx)
    {
        playerDirection = ctx.ReadValue<Vector2>();
    }

    public void Jump()
    {
        box.linearVelocity = new Vector2(box.linearVelocity.x, JumpPower);
    }

    void Start()
    {
        playerDirection = Vector2.zero; 
        box = GetComponent<Rigidbody2D>();
        animasi = GetComponent<Animator>();
    }

    void Update()
    {
       
        box.linearVelocity = new Vector2(playerDirection.x * speed, box.linearVelocity.y);

        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

       
        bool isMoving = Mathf.Abs(box.linearVelocity.x) > 0.1f;

        
        animasi.SetBool("lari", isMoving && isGrounded);
        animasi.SetBool("idle", !isMoving && isGrounded);
        animasi.SetBool("jump", !isGrounded);

        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
            Debug.Log("Jump!");
        }
    }
}
