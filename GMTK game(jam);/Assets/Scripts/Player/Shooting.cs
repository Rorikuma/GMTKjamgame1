using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    WeaponChanging weaponChanger;
    WeaponStats ws;

    float nextShotTime = 0;

    Rigidbody rb;
    
    void Shoot()
    {
        nextShotTime = Time.time + ws.Firerate;

        if(ws.ProjectilePrefab != null)
        {
            foreach (GameObject g in ws.Barrels)
            {
                GameObject projectile;
                projectile = SimplePool.Spawn(ws.ProjectilePrefab, g.transform.position, g.transform.rotation);
                projectile.GetComponent<Rigidbody>().velocity = g.transform.forward * projectile.GetComponent<ProjectileStats>().Speed;
            }
        }
        else
        {
            Debug.LogError("No projectile prefab.");
        }

        if(ws.MuzzleFlash != null)
        {
            Transform barrel = ws.Barrels[0].transform;
            GameObject g = Instantiate(ws.MuzzleFlash, barrel.position, barrel.rotation);
            Destroy(g, ws.MuzzleFlashDestroyTime);
        }

        rb.AddForce(-transform.forward * ws.ShootingForce);
    }

	void Start () {

        rb = GetComponent<Rigidbody>();
        weaponChanger = GetComponent<WeaponChanging>();
        ws = weaponChanger.Weapons[weaponChanger.ActiveWeapon].GetComponent<WeaponStats>();

	}
	
	void Update () {

        if (Input.GetMouseButton(0) && Time.time >= nextShotTime)
        {
            Shoot();
        }

	}
}
