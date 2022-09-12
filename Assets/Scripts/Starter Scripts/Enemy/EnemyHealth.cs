using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    //This class should be placed on anything enemy related! Or anything that the player can damage
    public int maxHealth = 100;
    public PlayerAttack playerAttack;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void DecreaseHealth(int value)
    {
        currentHealth -= value;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(playerAttack.isAttacking);
        if (collision.tag == "Player" && playerAttack.isAttacking)
        {
            Debug.Log("Testing.");
            DecreaseHealth(1);
            if (currentHealth == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
