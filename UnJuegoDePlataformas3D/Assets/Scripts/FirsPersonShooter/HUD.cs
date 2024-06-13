using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD : MonoBehaviour
{

    public CharacterStats characterStats;

    public Slider healthBar;
   // public Slider shieldBar;
    public TMP_Text ammo;
    public TMP_Text availableAmmo;

    public Sprite pistolIcon;
    public Sprite rifleIcon;
    public Image primaryWeapon;
    public Image secondaryWeapon;


    void Update()
    {
        healthBar.value = characterStats.HP;
        //shieldBar.value = characterStats.shield;

        //if (characterStats.equippedWeapon == "Pistol")
        //{
            primaryWeapon.overrideSprite = pistolIcon;
            //secondaryWeapon.overrideSprite = rifleIcon;

            ammo.text = characterStats.ammoPistol.ToString();
            availableAmmo.text = characterStats.ammoPistolAvailable.ToString();
        //}
        /*else if (characterStats.equippedWeapon == "Rifle")
        {
            primaryWeapon.overrideSprite = rifleIcon;
            secondaryWeapon.overrideSprite = pistolIcon;

            ammo.text = characterStats.ammoRifle.ToString();
            availableAmmo.text = characterStats.ammoRifleAvailable.ToString();
        }*/
    }

    
}
