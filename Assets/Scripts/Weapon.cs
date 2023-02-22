using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform MuzzlePoint;
    public GameObject projectilePrefab;
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Spawns or 'Fires' a bullet prefab if the left mouse button is pushed
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(projectilePrefab, MuzzlePoint.position, MuzzlePoint.rotation); // Simply makes bullet move depending on the transform of the 'muzzlepoint' and fires from the players relative postion
    }
}
