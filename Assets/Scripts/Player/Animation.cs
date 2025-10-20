using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class Animation : MonoBehaviour
{
    public PlayerMove playerMove;
    public Animator animator;

    void Update()
    {
        animator.SetFloat("ForwardMove", playerMove.moveAmt.y);
        animator.SetFloat("RightMove", playerMove.moveAmt.x);
    }
}