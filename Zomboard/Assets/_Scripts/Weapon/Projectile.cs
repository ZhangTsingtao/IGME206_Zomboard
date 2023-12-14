using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float lifeTime = 3;
    private float timer = 0.0f;
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > lifeTime) DestroyMyself();
    }
    private void OnCollisionEnter(Collision collision)
    {
        DestroyMyself();
    }
    private void DestroyMyself()
    {
        Destroy(gameObject);
    }
}
