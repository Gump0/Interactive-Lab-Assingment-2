using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 3; // Stores highest possible HP player can yield
    public int currentHP; // Stores the players current HP

    public HealthBar healthBar; // Referance used for the healthbar UI element
 
    void Awake()
    {
        currentHP = maxHP; // Always sets player HP to max whenever the game is reset

        healthBar.SetHealth(currentHP); // Healthbar stuff
    }
    public void PlayerTakeDamage(int damage) // Function that determines how the player takes damage
    {
        currentHP -= damage;
        healthBar.SetHealth(currentHP);
        if(currentHP <= 0)
        {
            SceneManager.LoadScene("GameOverScene"); // Simply, if the player runs out of health, the game ends
        }
    }
}

