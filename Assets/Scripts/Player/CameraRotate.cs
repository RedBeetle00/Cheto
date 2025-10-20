using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public Vector2 lookAmt;
    public float rotateSpeed;
    public float currentRot;

    void Update()
    {
        lookAmt = PlayerInput.inputLook.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        currentRot -= lookAmt.y * rotateSpeed * Time.deltaTime;
        currentRot = Mathf.Clamp(currentRot, -80, 80);
        transform.localRotation = Quaternion.Euler(currentRot, 0, 0);
    }
}