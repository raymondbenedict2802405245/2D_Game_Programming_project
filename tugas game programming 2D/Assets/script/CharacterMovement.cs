using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D capsule;
    private Vector2 playerDirection;

    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    private bool isGrounded;

    [SerializeField] private float speed;
    [SerializeField] private float JumpPower;

    public void Movement(InputAction.CallbackContext ctx)
    {
         playerDirection = ctx.ReadValue<Vector2>();
    }
    public void jump()
    {
        
        capsule.linearVelocityY = capsule.linearVelocityY+JumpPower;
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        capsule = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        capsule.linearVelocityX = playerDirection.normalized.x*speed;

        isGrounded  = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            jump();
            Debug.Log("jumpYay");
        }
    }
}
