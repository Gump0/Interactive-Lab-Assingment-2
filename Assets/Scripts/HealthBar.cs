using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerHealth playerHealth; // References players current HP through another script
    public Image fillimage;
    public Slider slider;

    void Awake()
   {
        slider.GetComponent<Slider>(); // Grabs slider component
   } 
    public void SetHealth(int health)
    {
        slider.value = health; // Sets slider position relative to players current HP
    }
}
