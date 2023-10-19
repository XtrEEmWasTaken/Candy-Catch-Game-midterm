using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDeletion : MonoBehaviour
{
    public GameObject CandyToSpawn;
    public int Candy = 0;
    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Candy")
        {
            Destroy(other.gameObject);
            if (gameObject == null) { Instantiate(CandyToSpawn); }
        }
    }
}
