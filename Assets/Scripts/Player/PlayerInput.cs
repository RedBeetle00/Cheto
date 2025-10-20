using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public InputAction inputMove;
    public InputAction inputLook;
    public InputAction inputJump;

    void Awake()
    {
        inputMove = InputSystem.actions.FindAction("Move");
        inputLook = InputSystem.actions.FindAction("Look");
        inputJump = InputSystem.actions.FindAction("Jump");
    }
}