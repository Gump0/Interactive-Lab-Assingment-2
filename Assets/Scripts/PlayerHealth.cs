using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 3;
    public int currentHP;

    public HealthBar healthBar;
 
    void Awake()
    {
        currentHP = maxHP;

        healthBar.SetHealth(currentHP);
    }
    public void PlayerTakeDamage(int damage)
    {
        currentHP -= damage;
        healthBar.SetHealth(currentHP);
        if(currentHP <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}

