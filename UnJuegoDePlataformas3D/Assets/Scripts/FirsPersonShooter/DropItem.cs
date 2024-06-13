using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public GameObject[] prefabs;    //[0] pistolAmmo, [1] health

    public void DropRandomItem()
    {
        int prefabToInstantiate = Random.Range(0, 8);

        if (prefabToInstantiate < 2)
        {
            Instantiate(prefabs[prefabToInstantiate], transform.position + new Vector3(0,1,0), Quaternion.identity);
        }
    }
}
