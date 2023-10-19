using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SearchService;
using UnityEngine.UIElements;

public class CandyCollection : MonoBehaviour
{
    public GameObject CandyToSpawn;
    public int Candy = 0;
    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Candy")
        {
            Candy++;
            Debug.Log(Candy);
            Destroy(other.gameObject);
            if (other.transform.tag == "Candy") { Instantiate(CandyToSpawn); }
        }

    }

}
