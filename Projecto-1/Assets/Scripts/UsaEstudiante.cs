using UnityEngine;
using packagesPersona;
using System.Collections.Generic;

public class Usarestudiante : MonoBehaviour
{
    List<Estudiante> listaE = new List<Estudiante>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Estudiante e1 = new Estudiante("2025_03", "Ing multimedia", "David Castro", "dacastro@uao.edu.co",
            "carrera 34");
        Estudiante e2 = new Estudiante("2023_03", "Ing Ambiental", "Maria Perez", "merez@uao.edu.co",
            "calle 14");

        listaE.Add(e1);
        listaE.Add(e2);

        for (int i = 0; i < listaE.Count; i++)
        {
            Debug.Log("name " + listaE[i].NameP + "Carrera " + listaE[i].NameCarreraE);
        }
    }

    void Update()
    {

    }
    
}
