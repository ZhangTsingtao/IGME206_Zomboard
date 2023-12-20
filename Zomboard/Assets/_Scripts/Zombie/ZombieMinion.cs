using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZombieMinion : ZombieBase
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Projectile")) GetDamage(1);

        if (collision.transform.CompareTag("Player"))
        {
            if (!ableToHit) return;

            HurtPlayer(collision.transform.GetComponent<HeroStatus>());
            collision.transform.GetComponent<HeroController>().GetHurtImpulse(transform.position);
            ableToHit = false;
        }
    }
    private void OnCollisionExit(Collision collision) 
    {
        if (collision.transform.CompareTag("Player"))
        {
            ableToHit = true;
        }
    }
}
