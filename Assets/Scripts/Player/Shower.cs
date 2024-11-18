using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower : MonoBehaviour
{
    private void OnTriggerEnter(Collider player)
    {
        if (player.transform.CompareTag("Player"))
        {
            player.transform.GetComponent<Cleaning>().AseoMimitchi(10);
        }
    }
}
