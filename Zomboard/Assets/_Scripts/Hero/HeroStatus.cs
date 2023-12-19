using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HeroStatus
{
    public static int HeroHealth = 20;

    public static void ResetStatus()
    {
        HeroHealth = 20;
    }

    public static void HeroGetHurt(int damage)
    {
        HeroHealth -= damage;
        Debug.Log("Hero get hurt, he's health is " + HeroHealth);
        if (HeroHealth <= 0) HeroDie();
    }

    public static void HeroDie()
    {
        Debug.Log("Hero Die!!!!");
    }
}
