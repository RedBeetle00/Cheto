using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public InputAction inputMove;
    public InputAction inputLook;
    public InputAction inputJump;
    public InputAction inputShoot;
    public InputAction inputInteract;
    public InputAction inputCrouch;
    public InputAction inputSprint;

    void Awake()
    {
        inputMove = InputSystem.actions.FindAction("Move");
        inputLook = InputSystem.actions.FindAction("Look");
        inputJump = InputSystem.actions.FindAction("Jump");
        inputShoot = InputSystem.actions.FindAction("Shoot");
        inputInteract = InputSystem.actions.FindAction("Interact");
        inputCrouch = InputSystem.actions.FindAction("Crouch");
        inputSprint = InputSystem.actions.FindAction("Sprint");
    }
}