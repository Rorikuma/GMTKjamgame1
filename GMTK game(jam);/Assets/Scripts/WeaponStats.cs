using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats : MonoBehaviour {

    public WeaponTypes WeaponType;

    public float Firerate;
    public float Damage;
    public float ShootingForce;
    public float MuzzleFlashDestroyTime;

    public GameObject ProjectilePrefab;
    public GameObject[] Barrels;
    public GameObject MuzzleFlash;

}
