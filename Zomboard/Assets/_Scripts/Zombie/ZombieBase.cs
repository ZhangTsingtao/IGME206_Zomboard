using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieBase : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform hero;

    private int health = 10;
    private int attack = 1;
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

    public virtual int HurtPlayer()
    {
        return attack;
    }

    public virtual void ZombieDie()
    {
        Destroy(gameObject);
    }
}
