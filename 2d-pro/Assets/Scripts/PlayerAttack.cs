using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public GameObject gun;
    public Transform t; 
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
        //sees which key was last presses
        //takes it that direction
        //rotates to match
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            t.localPosition = new Vector3(-1, 0, 0);
            t.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            t.localPosition = new Vector3(0, 2, 0);
            t.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            t.localPosition = new Vector3(0, -2, 0);
            t.rotation = Quaternion.Euler(0, 0, -180);
        }
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            t.localPosition = new Vector3(1, 0, 0);
            t.rotation = Quaternion.Euler(0, 0, -90);
        }
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(gun, t.position, t.rotation);
        }
    }
}
