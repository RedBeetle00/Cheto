using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public PlayerInput playerInput;
    public GroundCheck groundCheck;
    public Rigidbody rb;

    public Vector2 moveAmt;
    public Vector2 lookAmt;

    public float moveSpeed;
    public float rotateSpeed;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
        groundCheck = GetComponentInChildren<GroundCheck>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        moveAmt = playerInput.inputMove.ReadValue<Vector2>();
        lookAmt = playerInput.inputLook.ReadValue<Vector2>();
        
        if (playerInput.inputJump.WasPressedThisFrame() && groundCheck.isGrounded)
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Walking();
        Rotating();
    }

    private void Walking()
    {
        rb.MovePosition(rb.position + transform.forward * moveAmt.y * moveSpeed * Time.deltaTime);
        rb.MovePosition(rb.position + transform.right * moveAmt.x * moveSpeed * Time.deltaTime);
    }

    private void Rotating()
    {
        float rotationAmount = lookAmt.x * rotateSpeed * Time.deltaTime;
        Quaternion deltaRotation = Quaternion.Euler(0, rotationAmount, 0);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    private void Jump()
    {
        rb.AddForce(new Vector3(0, 5f, 0), ForceMode.Impulse);
    }
}