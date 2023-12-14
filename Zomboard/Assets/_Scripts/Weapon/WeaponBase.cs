using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WeaponBase : MonoBehaviour
{
    [Header("Assign")]
    public GameObject projectile;
    
    public Transform firePoint;

    protected float fireSpeed = 100;
    protected bool canFire = false;

    public float fireInterval = 0.5f;
    protected float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        FireBase();
    }
    

    protected void FireBase()
    {
        CountTimer();

        //fire
        if (Input.GetMouseButton(0) && canFire == true) FireProjectile();
    }
    protected void CountTimer()
    {
        if (!canFire)
        {
            timer += Time.deltaTime;

            if (timer > fireInterval)
            {
                canFire = true;
                timer = 0.0f;
            }
        }
    }
    protected void FireProjectile()
    {
        canFire = false;

        GameObject proj = Instantiate(projectile, firePoint.position, Quaternion.identity, transform.parent.parent);
        proj.GetComponent<Rigidbody>().velocity = transform.forward * fireSpeed;
    }
}
