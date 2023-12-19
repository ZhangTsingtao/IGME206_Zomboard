using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieBase : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform hero;

    [SerializeField] private int health = 10;
    private int attack = 1;

    [SerializeField] protected bool ableToHit = true;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        hero = GameObject.FindGameObjectWithTag("Player").transform;
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
    }

    public virtual void HurtPlayer()
    {
        HeroStatus.HeroGetHurt(attack);
    }

    public virtual void ZombieDie()
    {
        Destroy(gameObject);
    }
}
