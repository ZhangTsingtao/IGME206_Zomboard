using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthBarDisplay : MonoBehaviour
{
    [Header("Assign InternalHealthBar here")]
    public GameObject healthBarUI;

    private Vector3 initialScale;
    private void Start()
    {
        initialScale = healthBarUI.transform.localScale;
    }

    public void UpdateHealthBar(float healthPercentage)
    {
        if(healthBarUI == null)
        {
            Debug.LogWarning("No InternalHealthBar attached on this script, Assign InternalHealthBar here!");
            return;
        }
        healthBarUI.transform.localScale = new Vector3(initialScale.x * healthPercentage, initialScale.y, initialScale.z);
    }
}
