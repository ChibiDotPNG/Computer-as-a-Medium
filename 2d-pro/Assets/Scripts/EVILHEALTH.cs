using TMPro;
using UnityEngine;

public class EVILHEALTH : MonoBehaviour
{
    public int health = 10;
    public TMP_Text healthText;
    public GameObject EVILGUY;
    void Start()
    {
        healthText.text = "Health: " + health;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health;
        if (health < 1)
        {
            EVILGUY.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bullet"))
        {
            health -= 1;

        }
    }
}