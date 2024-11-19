using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : MonoBehaviour
{
    private void OnTriggerEnter(Collider player)
    {
        if (player.transform.CompareTag("Player"))
        {
            player.transform.GetComponent<Sleeping>().Dormir(true);
        }
    }

    private void OnTriggerExit(Collider player)
    {
        if (player.transform.CompareTag("Player"))
        {
            player.transform.GetComponent<Sleeping>().Dormir(false);
        }
    }
}
