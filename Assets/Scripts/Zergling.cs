using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zergling : MonoBehaviour
{
    public int hitPoints = 100;
    public int damage;

    public PlayerHealth playerHealth;

    void Awake()
    {
        /*Player = GameObject.Find("Player").PlayerHealth;*/
    }
    public void TakeDamage(int damage)
    {
        hitPoints -= damage;

        if (hitPoints <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.PlayerTakeDamage(damage);
        }
    }
}