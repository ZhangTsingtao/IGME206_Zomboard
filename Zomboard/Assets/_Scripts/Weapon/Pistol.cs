using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : WeaponBase
{
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
}
