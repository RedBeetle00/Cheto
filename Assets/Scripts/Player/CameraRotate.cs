using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    public Vector2 lookAmt;

    public float rotateSpeed;
    private float currentRot;

    private void Awake()
    {
        playerInput = GetComponentInParent<PlayerInput>();
    }

    void Update()
    {
        lookAmt = playerInput.inputLook.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        currentRot -= lookAmt.y * rotateSpeed * Time.deltaTime;
        currentRot = Mathf.Clamp(currentRot, -90, 90);
        transform.localRotation = Quaternion.Euler(currentRot, 0, 0);
    }
}