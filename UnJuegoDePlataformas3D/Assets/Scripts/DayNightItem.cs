using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightItem : MonoBehaviour
{
    public DayNightManager timeManager;
    public float rotationTime = 2.0f;
    public Transform gameAreaCenter;
    public float gameAreaSizeX = 50;
    public float gameAreaSizeZ = 50;

    void Start()
    {
        Respawn();
    }

    void Update()
    {
        this.transform.Rotate(0, 360 * Time.deltaTime / rotationTime, 0);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
            Respawn();
    }

    void Respawn()
    {

        this.transform.position = new Vector3(
            gameAreaCenter.position.x + Random.Range(-gameAreaSizeX / 2.0f, gameAreaSizeX / 2.0f),
            50,
            gameAreaCenter.position.z + Random.Range(-gameAreaSizeZ / 2.0f, gameAreaSizeZ / 2.0f));

        RaycastHit hit;
        if (Physics.Raycast(new Ray(this.transform.position, Vector3.down), out hit, 100.0f))
            this.transform.position = hit.point + Vector3.up;

        ParticleSystem explosion = GetComponentInChildren<ParticleSystem>();
        explosion.Play();

        timeManager.Reset();
    }
}
