using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zergling : MonoBehaviour
{
    public int hitPoints = 100; // HP of the Zergling
    public int damage; // Stores damage value that will be dealt by the player
    public PlayerHealth playerHealth; // Used to reference the PlayerHealth script

    void Awake()
    {
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>(); // Grabs the PlayerHealth script for reference
    }
    public void TakeDamage(int damage) // Calculates how damage is dealt towards the enemy
    {
        hitPoints -= damage;

        if (hitPoints <= 0)
        {
            Die(); // if the health of the enemy is 0 or lower than it will run the custom 'Die' function
        }
    }

    public void Die()
    {
        Destroy(gameObject); // Simply destroys the gameObject on death
    }
    private void OnCollisionEnter2D(Collision2D collision) // Is used and referenced by the PlayerHealth script to calculate damage dealt to the player by contact of the enemy
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.PlayerTakeDamage(damage);
        }
    }
}