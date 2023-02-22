using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningPool : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyprefab;

    [SerializeField]
    private float spawningPoolInterval = 3f;
    [SerializeField]
    private bool canSpawn = true;
    void Start()
    {
        StartCoroutine(spawnEnemy());
    }

    private IEnumerator spawnEnemy()
    {
        WaitForSeconds wait = new WaitForSeconds (spawningPoolInterval);

        while (canSpawn)
        {
            yield return wait;

            Instantiate(enemyprefab, transform.position, Quaternion.identity);
        }
    }
}
