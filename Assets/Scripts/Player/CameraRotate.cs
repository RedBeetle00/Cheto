using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public Vector2 lookAmt;
    public float rotateSpeed;

    void Update()
    {
        lookAmt = PlayerInput.inputLook.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        float rotationAmount = -(lookAmt.y * rotateSpeed * Time.deltaTime);
        transform.rotation *= Quaternion.Euler(Mathf.Clamp(rotationAmount, -80, 80), 0, 0);
    }
}