using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : MonoBehaviour
{
    private SpriteRenderer spi;
    public Rigidbody2D body;
    public GameObject Player;
    public float enemySpeed;
    private float distance;

    public bool zergFacingRight;
    void Awake()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        spi = GetComponent<SpriteRenderer>();

        Player = GameObject.Find("Player");

        zergFacingRight = true;
    }

    void FixedUpdate()
    {
        // USING GAMEOBJECT PLAYER TO FIND OBJECT TO "CHASE" DON'T TOUCH
       distance = Vector2.Distance(transform.position, Player.transform.position);
       Vector2 direction = Player.transform.position - transform.position;

       transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, enemySpeed * Time.deltaTime);
    }
    public static GameObject thingonstage;
}
