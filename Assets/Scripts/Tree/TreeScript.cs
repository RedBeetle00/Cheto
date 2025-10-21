using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public PlayerAttack playerAttack;
    public GameObject weapon;
    public GameObject tree;
    void Start()
    {
        weapon = GameObject.FindWithTag("Weapon");
        tree = GameObject.Find("Statuia");
        
    }

    private void OnTriggerEnter(Collider weapon)
    {
        if (playerAttack.animator.GetBool("IsAttack"))
        {
            Destroy(tree);
        }
    }
}