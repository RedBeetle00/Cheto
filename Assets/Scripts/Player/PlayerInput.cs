using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public static InputAction inputMove;
    public static InputAction inputLook;

    void Awake()
    {
        inputMove = InputSystem.actions.FindAction("Move");
        inputLook = InputSystem.actions.FindAction("Look");
    }
}