using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public UIHealth healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth < 1)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage()
    {
        if (this == CompareTag("Player"))
        {
            healthBar.SetHealth(currentHealth);
        }
    }
}