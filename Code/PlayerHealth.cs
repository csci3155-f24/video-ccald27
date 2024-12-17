using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public TMP_Text healthState;
    private int currentHealth;
    public int maxHealth = 100;

    void Start()
    {
        currentHealth = maxHealth;
        healthState.text = "Health: " + currentHealth.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(10);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            TakeDamage(20);
        }
        healthState.text = "Heath: " + currentHealth.ToString();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Max(currentHealth, 0); 

    }
    public void Heal(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Min(currentHealth, maxHealth); 
    } 
}
