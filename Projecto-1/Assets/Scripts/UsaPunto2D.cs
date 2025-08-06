using UnityEngine;
using packages2d;
using System.Collections.Generic;

public class UsaPunto2D : MonoBehaviour
{
    List<punto2D> listaPuntos = new List<punto2D>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        punto2D p1 = new punto2D(10.5, 20.3);
        punto2D p2 = new punto2D(-5.2, 15.7);

        listaPuntos.Add(p1);
        listaPuntos.Add(p2);

        for (int i = 0; i < listaPuntos.Count; i++)
        {
            Debug.Log("X: " + listaPuntos[i].X1 + " Y: " + listaPuntos[i].Y1);
        }
    }

    void Update()
    {

    }
}