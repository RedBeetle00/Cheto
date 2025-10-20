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
        float rotationAmount = (lookAmt.y * rotateSpeed * Time.deltaTime);
        currentRot -= rotationAmount;
        currentRot = Mathf.Clamp(currentRot, -80, 80);
        transform.rotation = Quaternion.Euler(Mathf.Clamp(currentRot, -80, 80), 0, 0);
    }
}