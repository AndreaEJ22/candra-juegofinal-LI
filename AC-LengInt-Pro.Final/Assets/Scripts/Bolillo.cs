using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bolillo : MonoBehaviour
{
    TextMeshPro bolillo;
    int number = 0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        /*if (other.transform.CompareTag("Player"))
        {
            number = +1;
            bolillo.text = number.ToString();
        }*/
    }
}
