using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HeroInventory", menuName = "ScriptableObjects/HeroInventory", order = 1)]
public class HeroInventorySO : ScriptableObject
{
    [SerializeField] private List<GameObject> weapons;
    public List<GameObject> Weapons {  get { return weapons; } set { weapons = value; } }

    private int currentWeaponIndex = 0;

    public GameObject SwitchWeapon(bool forward)
    {
        if (forward)
        {
            currentWeaponIndex++;
            if (currentWeaponIndex >= weapons.Count) currentWeaponIndex = 0;
            Debug.Log("Switch weapon to:" + weapons[currentWeaponIndex]);
            return weapons[currentWeaponIndex];
        }
        else
        {
            currentWeaponIndex--;
            if (currentWeaponIndex < 0) currentWeaponIndex = weapons.Count - 1;
            Debug.Log("Switch weapon to:" + weapons[currentWeaponIndex]);
            return weapons[currentWeaponIndex];
        }
    }
    public void ResetInventory()
    {
        var firstWeapon = weapons[0];
        Debug.Log("Add Pistol");
        weapons.Clear();
        weapons.Add(firstWeapon);
        currentWeaponIndex = 0;
    }
    public GameObject GetFirstWeapon()
    {
        return weapons[0];
    }
    public void checkInventory()
    {
        if (Weapons.Contains(Weapons[0]))
        {

        }
        if (Weapons.Contains(Weapons[1]));
    }
}

