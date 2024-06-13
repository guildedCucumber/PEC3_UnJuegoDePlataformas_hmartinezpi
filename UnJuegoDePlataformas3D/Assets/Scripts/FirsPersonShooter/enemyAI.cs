using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class enemyAI : MonoBehaviour
{
    [HideInInspector] public PatrolState patrolState;
    //[HideInInspector] public AlertState alertState;
    [HideInInspector] public AggroState aggroState;
    [HideInInspector] public AIEnemyState currentState;

    [SerializeField] private AudioClip getHitSound;

    public DropItem dropItem;

    [HideInInspector] public NavMeshAgent navMeshAgent;

    public float life = 100.0f;
    public float timeBetweenAttacks = 1.0f;
    public float damageForce = 10.0f;
    public float rotationTime = 3.0f;
    public float shootHeight = 0.5f;
    public Transform[] wayPoints;
    public float speed = 0.0f;

    public AudioSource audioSource;
    public GameObject particleSystem;

    ParticleSystem system;
    public Animator anim;

    void Start()
    {
        // Creamos los estados de nuestra IA.
        patrolState = new PatrolState(this);
        //alertState  = new AlertState(this);
        aggroState = new AggroState(this);

        // Le decimos que inicialmente empezará patrullando
        currentState = patrolState;

        // Guardamos la referencia en nuestro NavMesh Agent
        navMeshAgent = GetComponent<NavMeshAgent>();

        anim = GetComponent<Animator>();

        particleSystem.SetActive(false);
        system = GetComponentInChildren<ParticleSystem>();

        system.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
    }
    
    void Update()
    {
        currentState.UpdateState();

        anim.SetFloat("Speed", speed);
    }

    // Cuando el player nos dispara, nos quitamos vida y avisamos al estado en el que estemos de que nos han disparado.
    public void Hit(float damage)
    {
        life -= damage;
        GetHitSound();
        anim.SetTrigger("Hit");
        currentState.Impact();
        Debug.Log("Enemy hit: " + life);

        if (life < 0) Die();
    }

    void GetHitSound()
    {
        audioSource.clip = getHitSound;
        audioSource.Play();
    }

    void Die()
    {
        anim.SetBool("Die", true);
        dropItem.DropRandomItem();

        particleSystem.SetActive(true);

        var emission = system.emission;
        emission.enabled = true;

        Destroy(this.gameObject, 5.0f);
    }

    // Ya que nuestros states no heredan de MonoBehaviour, tendremos que avisarles cuando algo entra, está o sale de nuestro trigger.
    void OnTriggerEnter(Collider col)
    {
        currentState.OnTriggerEnter(col);
    }

    void OnTriggerStay(Collider col)
    {
        currentState.OnTriggerStay(col);
    }

    void OnTriggerExit(Collider col)
    {
        currentState.OnTriggerExit(col);
    }
}
