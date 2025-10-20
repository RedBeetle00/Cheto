using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public Vector2 lookAmt;
    public float rotateSpeed;
    private float currentRot;

    void Update()
    {
        lookAmt = PlayerInput.inputLook.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        currentRot -= lookAmt.y * rotateSpeed * Time.deltaTime;
        currentRot = Mathf.Clamp(currentRot, -90, 90);
        transform.localRotation = Quaternion.Euler(currentRot, 0, 0);
    }
}