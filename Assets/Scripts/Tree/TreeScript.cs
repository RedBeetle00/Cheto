using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public GameObject player;
    public PlayerAttack playerAttack;
    public GameObject tree;
    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        tree = this.gameObject;
        playerAttack = player.GetComponent<PlayerAttack>();
        
    }

    private void OnTriggerEnter(Collider weapon)
    {
        if (playerAttack.animator.GetBool("IsAttack"))
        {
            Destroy(tree);
        }
    }
}