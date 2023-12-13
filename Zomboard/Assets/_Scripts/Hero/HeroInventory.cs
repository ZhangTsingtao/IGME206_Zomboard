using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInventory : MonoBehaviour
{
    [Header("Assign")]
    public HeroInventorySO heroInventorySO;
    public GameObject weaponGO;
    public Transform handPosition;

    private void Start()
    {
        Destroy(weaponGO);
        weaponGO = Instantiate(heroInventorySO.GetFirstWeapon(), handPosition.position, transform.rotation, transform);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            SwitchWeapon(false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            SwitchWeapon(true);
        }
    }

    private void SwitchWeapon(bool forward)
    {
        Destroy(weaponGO);
        weaponGO = Instantiate(heroInventorySO.SwitchWeapon(forward), handPosition.position, transform.rotation, transform);
    }
}
