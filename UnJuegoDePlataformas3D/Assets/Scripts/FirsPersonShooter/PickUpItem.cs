using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public enum Type
    {
        AmmoPistol,
        AmmoRifle,
        Health,
        Shield,
        KeyOne,
        KeyTwo
    }

    public Type type;

    ShieldSystem shield;
    WeaponSystem weapon;

    ParticleSystem system;

    void Start()
    {
        shield = GameObject.Find("/Player/Shield").GetComponent<ShieldSystem>();
        weapon = GameObject.Find("/Player/FirstPersonCharacter/WeaponSystem").GetComponent<WeaponSystem>();
       
        system = GetComponentInChildren<ParticleSystem>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            switch (type)
            {
                case Type.AmmoPistol:
                    Debug.Log("You found pistol ammo!");
                    Destroy(gameObject, 1.0f);  //PlayEffect();
                    weapon.PickupAmmo(10, "Pistol");
                    break;

                case Type.Health:
                    Debug.Log("You found health!");
                    Destroy(gameObject, 1.0f);  //PlayEffect();
                    shield.UpdateHealth(20.0f);
                    break;
            }
        }
    }

    void PlayEffect()
    {
        //system.Play(true);

        Destroy(gameObject, 1.0f);
    }
}
