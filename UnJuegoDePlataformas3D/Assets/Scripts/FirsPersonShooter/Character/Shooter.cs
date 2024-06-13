using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public WeaponSystem weapon;

    public GameObject decalPrefab;
    public AudioSource audioSource;

    Animator anim;

    [SerializeField] private AudioClip fireSound;
    [SerializeField] private AudioClip reloadSound;

    private float decalTime = 5.0f;
    private float reloadTime = 3.0f;
    private float range = 10.0f;

    private bool shooting = true;
    private bool reloading = false;
    private bool equipped = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Weapon", true);
    }

    void Update()
    {
        /*
        // Shooting position
        if (Input.GetKeyDown("1"))
        {
            if (!equipped)
                anim.SetBool("Weapon", true);
            else
                anim.SetBool("Weapon", false);
        }
        */
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            // Weapon is always pistol
            string weaponName = weapon.GetWeapon();

            // Check player can shoot and is not reloading
            if (shooting && !reloading) // && equipped)
            {
                // Check player has ammo
                if (weapon.GetAvailableAmmo(weaponName) > 0)
                {
                    anim.SetTrigger("Shoot");

                    Ray ray = new Ray(transform.position, transform.forward);
                    //if (Physics.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)), out hit))
                    //if (Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2)), out hit))
                    if (Physics.Raycast(ray, out hit));
                    {
                        if (hit.collider.tag == "Enemy")
                        {
                            hit.collider.gameObject.GetComponent<enemyAI>().Hit(weapon.GetDamage());
                        }


                        PlayBulletSound();

                        // Measure rate of fire
                        float rateOfFire = weapon.GetRateOfFire();
                        StartCoroutine(Shoot(rateOfFire));

                        // Update ammo count
                        weapon.UpdateAmmo(-1, weaponName);
                    }
                }
                // If player is out of ammo
                else
                {
                    Debug.Log("RELOAD!");
                }
            }

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            // Reload weapon
            weapon.Reload();

            // Do not shoot for 3 seconds
            StartCoroutine(Reloading(reloadTime));

            PlayReloadSound();
        }
    }

    private IEnumerator Shoot(float waitTime)
    {
        shooting = false;
        yield return new WaitForSeconds(waitTime);

        shooting = true;
    }

    private IEnumerator ClearDecal(float waitTime, GameObject o)
    {
        if (o != null)
        {
            yield return new WaitForSeconds(waitTime);
            Destroy(o);
        }

        yield return null;
    }

    private IEnumerator Reloading(float waitTime)
    {
        reloading = true;
        yield return new WaitForSeconds(waitTime);

        reloading = false;
    }

    private void PlayBulletSound()
    {
        audioSource.clip = fireSound;
        audioSource.Play();
    }

    private void PlayReloadSound()
    {
        audioSource.clip = reloadSound;
        audioSource.Play();
    }
}