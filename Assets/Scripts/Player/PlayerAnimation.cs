using UnityEngine;

public class Animation : MonoBehaviour
{
    public GameObject player;
    public PlayerMove playerMove;
    public Animator animator;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMove = GetComponentInParent<PlayerMove>();
        animator = player.GetComponentInChildren<Animator>();
    }

    void Update()
    {
        animator.SetFloat("ForwardMove", playerMove.moveAmt.y);
        animator.SetFloat("RightMove", playerMove.moveAmt.x);
    }
}