using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerInput playerInput;
    public Rigidbody rb;
    public Vector2 moveAmt;
    public Vector2 lookAmt;

    public float moveSpeed;
    public float rotateSpeed;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        moveAmt = PlayerInput.inputMove.ReadValue<Vector2>();
        lookAmt = PlayerInput.inputLook.ReadValue<Vector2>();
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
}