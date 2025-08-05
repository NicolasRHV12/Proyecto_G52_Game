using UnityEngine;
using System;
using packagePunto2D;
using System.Collections.Generic;


public class UsoPunto2D : MonoBehaviour
{
    List<Punto2D> listaP = new List<Punto2D>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Punto2D p1 = new Punto2D(2025, 345);
        Punto2D p2 = new Punto2D(2024, 354);

        listaP.Add(p1);
        listaP.Add(p2);

        for (int i = 0; i < listaP.Count; i++)
        {
            Debug.Log("Punto X: " + listaP[i].X+ "Punto Y:" + listaP[i].Y);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
