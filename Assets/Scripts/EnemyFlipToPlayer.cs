using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class EnemyFlipToPlayer : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public Transform Player;
   public void Awake()
    {
        this.spriteRenderer = this.GetComponent<SpriteRenderer>(); // Grabs the sprite renderer of the enemy

        Player = GameObject.Find("Player").transform; // Grabs the current location of the player
    }

    public void Update()
    {
        this.spriteRenderer.flipX = Player.transform.position.x < this.transform.position.x; // Simply fli[ps the spire depending on the location of the player relative to the enemies position
    }
}
