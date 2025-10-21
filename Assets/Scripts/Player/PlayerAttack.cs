using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public PlayerInput playerInput;
    public GameObject weapon;
    public Animator animator;

    private void Start()
    {
        weapon = GameObject.FindWithTag("Weapon");
        playerInput = GetComponent<PlayerInput>();
        animator = weapon.GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        animator.SetBool("IsAttack", playerInput.inputAttack.IsPressed());
    }
}