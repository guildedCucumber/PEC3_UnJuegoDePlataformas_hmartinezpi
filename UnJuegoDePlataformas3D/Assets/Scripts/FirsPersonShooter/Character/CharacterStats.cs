using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public float HP { get; private set; }
    //public float shield { get; private set; }
    public int ammoPistol { get; private set; }
    public int ammoRifle { get; private set; }
    public int ammoPistolAvailable { get; private set; }
    public int ammoRifleAvailable { get; private set; }
    public string equippedWeapon { get; private set; }

    ShieldSystem shieldSystem;
    WeaponSystem weaponSystem;

    GameManager gameManager;


    void Start()
    {
        shieldSystem = GetComponentInParent<ShieldSystem>();
        weaponSystem = GameObject.Find("/Player/WeaponSystem").GetComponent<WeaponSystem>();

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        equippedWeapon = weaponSystem.GetWeapon();

        ammoPistol = weaponSystem.GetReloadAmmo("Pistol");
        ammoRifle = weaponSystem.GetReloadAmmo("Rifle");

        ammoPistolAvailable = weaponSystem.GetAvailableAmmo("Pistol");
        ammoRifleAvailable = weaponSystem.GetAvailableAmmo("Rifle");

        HP = shieldSystem.GetHP();
        //shield = shieldSystem.GetShield();

        if (HP <= 0)
            Die();
    }

    void Die()
    {
        gameManager.ResetGame();
    }
}
