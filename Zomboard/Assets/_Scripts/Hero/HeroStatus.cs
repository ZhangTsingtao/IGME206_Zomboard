using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStatus : MonoBehaviour
{
    public int HeroHealth = 20;
    private int initialHealth;
    private HealthBarDisplay healthBarDisplay;
    private void Start()
    {
        initialHealth = HeroHealth;
        healthBarDisplay = GetComponent<HealthBarDisplay>();
    }
    public void ResetStatus()
    {
        HeroHealth = 20;
    }

    public void HeroGetHurt(int damage)
    {
        HeroHealth -= damage;
        Debug.Log("Hero get hurt, he's health is " + HeroHealth);
        if (HeroHealth <= 0) HeroDie();

        if (healthBarDisplay == null)
        {
            Debug.LogWarning("No HealthBarDisplay found on this gameObject, attach one on it!");
            return;
        }

        healthBarDisplay.UpdateHealthBar((float)HeroHealth / (float)initialHealth);
    }

    public void HeroDie()
    {
        Debug.Log("Hero Die!!!!");
    }
}
