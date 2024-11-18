using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    private void OnTriggerEnter(Collider player)
    {
        if (player.transform.CompareTag("Player"))
        {
            player.transform.GetComponent<Feeding>().AlimentarMimitchi(10);
        }
    }
}
