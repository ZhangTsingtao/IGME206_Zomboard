using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UZI : WeaponBase
{
    // Start is called before the first frame update
    void Start()
    {
        fireInterval = fireInterval / 10;
        GetRaycastReference();
    }

    // Update is called once per frame
    void Update()
    {
        FireBase();
    }
}
