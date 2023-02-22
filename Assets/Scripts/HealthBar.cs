using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Image fillimage;
    public Slider slider;

    void Awake()
   {
        slider.GetComponent<Slider>();
   } 
    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
