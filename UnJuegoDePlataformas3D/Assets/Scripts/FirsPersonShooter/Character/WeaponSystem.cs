using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{

    [SerializeField] private GameObject pistol;
    [SerializeField] private GameObject rifle;

    private GameObject equippedWeapon;

    // WEAPON CHARACTERISTICS.
    private string weaponName;
    private float damage;
    private float shotSpeed;
    private float rateOfFire;

    private int ammoPistol;
    private int ammoRifle;
    private int availableAmmoPistol;
    private int availableAmmoRilfe;

    // Start is called before the first frame update
    void Start()
    {
        equippedWeapon = pistol;

        ammoPistol = 25;
        ammoRifle = 90;
        availableAmmoPistol = ammoPistol;
        availableAmmoRilfe = ammoRifle;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangeWeapon();
        }

        if (equippedWeapon == pistol)
        {
            pistol.SetActive(true);
            rifle.SetActive(false);
        }
        else if (equippedWeapon == rifle)
        {
            rifle.SetActive(true);
            pistol.SetActive(false);
        }
        */
    }

    void ChangeWeapon()
    {
        if (equippedWeapon == pistol)
            equippedWeapon = rifle;
        else
            equippedWeapon = pistol;
    }

    public string GetWeapon()
    {
        if (equippedWeapon == pistol)
            weaponName = "Pistol";
        else
            weaponName = "Rifle";

        return weaponName;
    }

    public float GetRateOfFire()
    {
        if (equippedWeapon == pistol)
            rateOfFire = 1.0f;
        else
            rateOfFire = 0.1f;

        return rateOfFire;
    }

    public float GetDamage()
    {
        if (equippedWeapon == pistol)
            damage = 20.0f;
        else
            damage = 12.0f;

        return damage;
    }

    public int GetReloadAmmo(string weapon)
    {
        int tempAmmoPistol = ammoPistol;
        int tempAmmoRifle = ammoRifle;

        if (weapon == "Pistol")
            return tempAmmoPistol - availableAmmoPistol;

        if (weapon == "Rifle")
            return tempAmmoRifle - availableAmmoRilfe;

        return 0;
    }

    public int GetAvailableAmmo(string weapon)
    {
        if (weapon == "Pistol")
        {
            if (availableAmmoPistol > 11)
            {
                availableAmmoPistol = 11;
                return 11;
            }
            else
            {
                return availableAmmoPistol;
            }
        }

        if (weapon == "Rifle")
        {
            if (availableAmmoRilfe > 45)
            {
                availableAmmoRilfe = 45;
                return 45;
            }
            else
            {
                return availableAmmoRilfe;
            }
        }

        return 0;

    }

    public void UpdateAmmo(int ammoToAdd, string weapon)
    {

        if (weapon == "Pistol")
            availableAmmoPistol += ammoToAdd;
        
        if (weapon == "Rifle")
            availableAmmoRilfe += ammoToAdd;
    }

    public void PickupAmmo(int ammoToAdd, string weapon)
    {
        if (weapon == "Pistol")
            ammoPistol += ammoToAdd;

        if (weapon == "Rifle")
            ammoRifle += ammoToAdd;
    }

    public void Reload()
    {
        if (equippedWeapon == pistol)
        {
            int availableAmmo = GetReloadAmmo("Pistol");

            if (availableAmmo > 0)
                UpdateAmmo(availableAmmo, "Pistol");
            else
                // Show text NO AMMO
                Debug.Log("NO AMMO!");
        }
        else if (equippedWeapon == rifle)
        {
            int availableAmmo = GetReloadAmmo("Rifle");

            if (availableAmmo > 0)
                UpdateAmmo(availableAmmo, "Rifle");
            else
                // Show text NO AMMO
                Debug.Log("NO AMMO!");
        }
                
    }
}
