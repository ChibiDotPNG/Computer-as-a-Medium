using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public GameObject gun;
    public Transform facing;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(gun, facing.position, facing.rotation);
        }
    }
}
