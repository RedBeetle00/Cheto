using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private PlayerInput playerInput;
    private GameObject weapon;
    public Animator animator;

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        //animator = GetComponentInChildren<Animator>(); - Не придумал как сделать, чтобы он искал именно аниматор из объекта с тегом weapon
        weapon = GameObject.FindWithTag("Weapon");
    }

    private void Update()
    {
        animator.SetBool("IsAttack", playerInput.inputAttack.IsPressed());
    }
}