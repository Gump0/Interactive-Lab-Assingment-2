using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float velocity = 15f;
    public int damage = 50;
    public Rigidbody2D body;

    void Start()
    {
        body.velocity = transform.right * velocity;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Zergling enemy = hitInfo.GetComponent<Zergling>();
        Debug.Log(hitInfo.name);
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }

    }
    
}
