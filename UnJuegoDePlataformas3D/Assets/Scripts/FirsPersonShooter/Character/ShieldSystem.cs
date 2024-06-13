using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSystem : MonoBehaviour
{
    //private float maxShieldLife = 70.0f;
    //private float currentShieldLife;
    private float maxHP = 100.0f;
    private float playerHP;
    private float invulnerabilityTime = 1.0f;
    private bool takeDamage;

    GameManager gameManager;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //currentShieldLife = maxShieldLife;
        playerHP = maxHP;
        anim = GetComponent<Animator>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    /*
    public float GetShield()
    {
        return currentShieldLife;
    }
    */
    public float GetHP()
    {
        return playerHP;
    }
    /*
    public void UpdateShield(float lifeToAdd)
    {
        if (currentShieldLife >= maxShieldLife)
        {
            currentShieldLife = 70.0f;
            Debug.Log("MAX SHIELD!");
        }
        else
        {
            currentShieldLife += lifeToAdd;
            Debug.Log("CURRENT SHIELD: " + currentShieldLife);
        }
    }
    */
    public void UpdateHealth(float hp)
    {
        if (playerHP >= maxHP)
        {
            playerHP = 100.0f;
            Debug.Log("MAX HEALTH!");
        }
        else
        {
            playerHP += hp;
            Debug.Log("CURRENT HEALTH: " + playerHP);
        }
    }

    public void TakeDamage(float damage)
    {
        playerHP -= damage;
        anim.SetTrigger("Hit");

        /*
        if (currentShieldLife < 1)
        {
            playerHP -= damage;
        }
        else
        {
            float playerDamage = (damage / 100) * 15;

            playerHP -= playerDamage;
            currentShieldLife -= (damage - playerDamage);
        }
        */
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Finish")
            gameManager.ResetGame();
    }
}
