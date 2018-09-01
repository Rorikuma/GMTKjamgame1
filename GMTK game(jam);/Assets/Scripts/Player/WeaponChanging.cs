using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponTypes { Pistol, Shotgun, Machinegun }

public class WeaponChanging : MonoBehaviour {

    public int MaxWeapons = 2;
    public GameObject[] Weapons;

    WeaponStats ws;

    public int ActiveWeapon = 0;

	void Start () {

        ws = GetComponentInChildren<WeaponStats>();

        switch (ws.WeaponType)
        {
            case WeaponTypes.Pistol:
                ActiveWeapon = 0;
                break;

            case WeaponTypes.Shotgun:
                ActiveWeapon = 1;
                break;

            case WeaponTypes.Machinegun:
                ActiveWeapon = 2;
                break;

            default:
                Debug.LogError("This weapon type is not set up.");
                break;
        }

	}
	
	void Update () {
		


	}
}
