using System;
using UnityEngine;
using UnityEngine.UI;
public class UIHealth : MonoBehaviour
{
    public Slider Slider;
    public Health phealth;
    private float health;

    private void Start()
    {
        phealth = GameObject.FindWithTag("Player").GetComponent<Health>();
        health = phealth.maxHealth;
    }

    public void SetHealth()
    {
        Slider.value = health;
    }
    public void SetMaxHealth()
    {
        Slider.maxValue = health;
        Slider.value = health;
    }
}