using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour
{
    [Header("Assign")]
    public GameObject projectile;
    
    public Transform firePoint;

    protected float fireSpeed = 100;
    protected bool canFire = false;

    public float fireInterval = 0.5f;
    protected float timer = 0.0f;

    protected LookAtMouse lookAtMouse;

    // Start is called before the first frame update
    void Start()
    {
        GetRaycastReference();
    }

    // Update is called once per frame
    void Update()
    {
        FireBase();
    }
    
    protected void GetRaycastReference()
    {
        lookAtMouse = GetComponent<LookAtMouse>();
    }

    protected void FireBase()
    {
        CountTimer();

        //fire
        if (Input.GetMouseButton(0) && canFire == true) FireProjectile(lookAtMouse.raycastPosition);
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
    protected void FireProjectile(Vector3 fireDirection)
    {
        canFire = false;

        GameObject proj = Instantiate(projectile, firePoint.position, Quaternion.identity, transform.parent);
        proj.GetComponent<Rigidbody>().velocity = (fireDirection - firePoint.position).normalized * fireSpeed;
    }
}
