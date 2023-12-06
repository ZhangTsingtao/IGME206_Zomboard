using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowHero : MonoBehaviour
{
    private Transform hero;
    private Vector3 initialPositionOffset;

    private void Start()
    {
        hero = GameObject.FindGameObjectWithTag("Player").transform;
        initialPositionOffset = transform.position - hero.position;
    }
    void Update()
    {
        transform.position = hero.position + initialPositionOffset;
    }
}
