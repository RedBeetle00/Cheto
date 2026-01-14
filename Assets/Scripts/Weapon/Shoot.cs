using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public PlayerInput playerInput;

    void Awake()
    {
    }

    void Update()
    {
        if (playerInput.inputShoot.WasPressedThisFrame())
        {
            GameObject spawnObject = Instantiate(bullet, Vector3.zero, Quaternion.identity);
            Debug.Log("Penis");
        }
    }
}
