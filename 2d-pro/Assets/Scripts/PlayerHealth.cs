using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public TMP_Text healthText;
    void Start()
    {
        healthText.text = "Health: " + health;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health;
    }
}
