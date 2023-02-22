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
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();

        /*Player = Player.transform.Find("Player");*/
    }

    public void Update()
    {
        this.spriteRenderer.flipX = Player.transform.position.x < this.transform.position.x;
    }
}
