using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float velocity = 15f; // Sets bullet Velocity
    public int damage = 50; // Bullet DMG
    public Rigidbody2D body;

    void Start()
    {
        body.velocity = transform.right * velocity; // Simply makes bullet move depending on the transform of the 'muzzlepoint' and fires from the players relative postion
    }

    void OnTriggerEnter2D(Collider2D hitInfo) // Calculates damage and collisions between bullets and zerglings
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
