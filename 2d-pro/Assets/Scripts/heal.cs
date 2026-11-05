using UnityEngine;

public class heal : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject healpod;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        { 
            if (playerHealth.health <100)
            {
                playerHealth.health += 10;
                healpod.SetActive(false);
            }
        }
    }
}
