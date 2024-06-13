using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightActivator : MonoBehaviour
{
    public Material normalMaterial;
    public Material lightedMaterial;
    public GameObject myLights;
    public float minutesLeftToActivate = 30;

    DayNightManager dayNight;

    MeshRenderer myRenderer;

    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        dayNight = GameObject.Find("DayNightManager").GetComponent<DayNightManager>();
        TurnOff();
    }

    void Update()
    {
        if (dayNight.secondsLeft <= minutesLeftToActivate)
            TurnOn();
        else
            TurnOff();
    }

    void TurnOn()
    {
        myLights.SetActive(true);
        myRenderer.material = lightedMaterial;
    }

    void TurnOff()
    {
        myLights.SetActive(false);
        myRenderer.material = normalMaterial;
    }
}
