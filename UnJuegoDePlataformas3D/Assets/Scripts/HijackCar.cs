using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HijackCar : MonoBehaviour
{
    public GameObject carCam;
    public GameObject thirdPersonCam;

    ThirdPersonUserControl thirdPerson;
    CarUserControl carView;

    // Start is called before the first frame update
    void Start()
    {
        thirdPerson = GameObject.Find("Player").GetComponent<ThirdPersonUserControl>();
        carView = GetComponent<CarUserControl>();

        carCam.SetActive(false);
        carView.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            if (Input.GetKeyDown("t"))
            {
                EnableCarView();
            }
            else if (Input.GetKeyDown("p"))
            {
                EnableThirdPerson();
            }

        }
    }

    void EnableCarView()
    {
        carView.enabled = true;
        thirdPerson.enabled = false;

        carCam.SetActive(true);
        thirdPersonCam.SetActive(false); 
    }

    void EnableThirdPerson()
    {
        thirdPerson.enabled = true;
        carView.enabled = false;

        thirdPersonCam.SetActive(true);
        carCam.SetActive(false);
    }
}
