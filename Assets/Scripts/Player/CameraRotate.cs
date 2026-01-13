using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public PlayerInput playerInput;
    public Vector2 lookAmt;

    public float rotateSpeed;
    public float currentRot;

    private void Awake()
    {
        playerInput = GetComponentInParent<PlayerInput>();
    }

    void Update()
    {
        lookAmt = playerInput.inputLook.ReadValue<Vector2>();
        currentRot -= lookAmt.y * rotateSpeed * Time.deltaTime; // Принимает ввод игрока
        currentRot = Mathf.Clamp(currentRot, -90, 90); // Ограничивает этот ввод
        transform.localRotation = Quaternion.Euler(currentRot, 0, 0); // Вращает камеру
    }
}