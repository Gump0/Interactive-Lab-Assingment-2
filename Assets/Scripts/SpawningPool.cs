using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningPool : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyprefab; // Grabs enemy prefab to spawn

    [SerializeField]
    private float spawningPoolInterval; // The interval of spawning
    [SerializeField]
    private bool canSpawn = true;
    void Start() // Begins the zergling spawn routine
    {
        StartCoroutine(spawnEnemy());
    }

    private IEnumerator spawnEnemy() // Instantiates the zergling prefabs and creates an infinite cycle of spawning
    {
        WaitForSeconds wait = new WaitForSeconds (spawningPoolInterval);

        while (canSpawn)
        {
            yield return wait;

            Instantiate(enemyprefab, transform.position, Quaternion.identity);
        }
    }
}
