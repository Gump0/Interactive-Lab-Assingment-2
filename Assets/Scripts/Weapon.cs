using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform MuzzlePoint;
    public GameObject projectilePrefab;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(projectilePrefab, MuzzlePoint.position, MuzzlePoint.rotation);
    }
}
