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

    // Lerp Values
    public float enemyStartSpeed; // Preset start velocity
    public float enemyEndSpeed; // Preset end velocity
    public float lerpDuration = 3f; // How often the lerp is updated per frame
    public float elapsedTime; // Helps game determine how long the lerp fucntion has been running for on given enemy prefab
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

       transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, enemySpeed * Time.deltaTime); // Moves the enemy towards the player and utlizes the increased 'currentEnemySpeed' value
    
        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / lerpDuration; // Adds velocity and inteperates the "percentage complete" of the lerp :P

        enemySpeed = Mathf.Lerp(enemyStartSpeed, enemyEndSpeed, percentageComplete); // Lerp's between minimum enemy velocity and maxmimum enemy velocity and scales it over time using Time.deltaTime
    }
}