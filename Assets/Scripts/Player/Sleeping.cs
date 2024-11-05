using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sleeping : MonoBehaviour
{
    private float tiempo;
    [SerializeField] private Image barraSue�o;
    private float cantSue�o;
    [SerializeField] private bool duerme;
    void Start()
    {
        tiempo = 2f;
        cantSue�o = 100f;
        duerme = false;
    }

    void Update()
    {
        barraSue�o.fillAmount = cantSue�o / 100;
        if (tiempo > 0)
        {
            tiempo = tiempo - Time.deltaTime;
        }
        if (tiempo <= 0)
        {
            tiempo = 2f;
            if (cantSue�o > 0 && duerme == false)
            {
                cantSue�o -= 1f;
            }
        }
        if (duerme == true && cantSue�o < 100)
        {
            cantSue�o = cantSue�o + Time.deltaTime * 2;
        }
    }

    public float GetCantSue�o()
    {
        return cantSue�o;
    }

    public void RestarSue�o(float sue�o)
    {
        if (cantSue�o < 5 && cantSue�o > 0)
        {
            cantSue�o = 0;
        }
        if (cantSue�o >= 5)
        {
            cantSue�o -= sue�o;
        }
    }

    public void Dormir(bool dormir)
    {
        duerme = dormir;
    }

    public bool GetDormir()
    {
        return duerme;
    }
}
