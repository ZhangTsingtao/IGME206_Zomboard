using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieBase : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform hero;

    [SerializeField] protected int health = 5;
    protected int initialHealth;
    protected int attack = 1;

    protected bool ableToHit = true;

    protected HealthBarDisplay healthBarDisplay;

    // Start is called before the first frame update
    void Start()
    {
        initialHealth = health;
        agent = GetComponent<NavMeshAgent>();
        hero = GameObject.FindGameObjectWithTag("Player").transform;
        healthBarDisplay = GetComponent<HealthBarDisplay>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(hero.position);
    }

    public virtual void GetDamage(int damage)
    {
        health -= damage;
        if (health <= 0) ZombieDie();

        if (healthBarDisplay == null) 
        {
            Debug.LogWarning("No HealthBarDisplay found on this gameObject, attach one on it!");
            return;
        }

        healthBarDisplay.UpdateHealthBar((float)health/(float)initialHealth);
    }

    public virtual void HurtPlayer(HeroStatus hero)
    {
        hero.HeroGetHurt(attack);
    }

    public virtual void ZombieDie()
    {
        PlayerScore.Instance.AddScore(1);
        Destroy(gameObject);
    }
}
