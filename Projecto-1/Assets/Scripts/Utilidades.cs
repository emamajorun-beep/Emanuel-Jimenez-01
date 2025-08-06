using UnityEngine;
using System.Collections.Generic;
using System.IO;
using packagesPersona;
using packages2d;
using System;

public class Utilidades : MonoBehaviour
{
    private void Start()
    {
        GuardarEjemploEstudiantes();
        GuardarEjemploPuntos2D();
    }

    public void GuardarEjemploEstudiantes()
    {
        var listaEstudiantes = new List<Estudiante>
        {
            new Estudiante("2025_01", "Ing. Multimedia", "Ana García", "agarcia@uao.edu.co", "Calle 15 #30-25"),
            new Estudiante("2025_02", "Ing. Sistemas", "Carlos López", "clopez@uao.edu.co", "Carrera 20 #45-10"),
            new Estudiante("2025_03", "Ing. Industrial", "María Rodríguez", "mrodriguez@uao.edu.co", "Avenida 6 #12-34")
        };
        GuardarEstudiantesJSON(listaEstudiantes);
    }

    public void GuardarEjemploPuntos2D()
    {
        var listaPuntos = new List<punto2D>
        {
            new punto2D(10.5, 20.3),
            new punto2D(-5.2, 15.7),
            new punto2D(0, 0),
            new punto2D(100.1, -50.8)
        };
        GuardarPuntos2DJSON(listaPuntos);
    }

    // Método para guardar lista de estudiantes en JSON
    public void GuardarEstudiantesJSON(List<Estudiante> listaEstudiantes, string nombreArchivo = "estudiantes.json")
    {
        try
        {
            // Crear wrapper para la lista (Unity JsonUtility requiere un objeto contenedor)
            EstudiantesWrapper wrapper = new EstudiantesWrapper
            {
                estudiantes = listaEstudiantes
            };

            // Convertir a JSON con formato legible
            string json = JsonUtility.ToJson(wrapper, true);

            // Obtener la ruta del archivo en la carpeta persistente
            string rutaArchivo = Path.Combine(Application.persistentDataPath, nombreArchivo);

            // Escribir el archivo
            File.WriteAllText(rutaArchivo, json);

            Debug.Log($"Lista de estudiantes guardada exitosamente en: {rutaArchivo}");
            Debug.Log($"Contenido JSON:\n{json}");
        }
        catch (System.Exception e)
        {
            Debug.LogError($"Error al guardar estudiantes: {e.Message}");
        }
    }

    // Método para guardar lista de puntos 2D en JSON
    public void GuardarPuntos2DJSON(List<punto2D> listaPuntos, string nombreArchivo = "puntos2d.json")
    {
        try
        {
            // Crear wrapper para la lista
            PuntosWrapper wrapper = new PuntosWrapper
            {
                puntos = listaPuntos
            };

            // Convertir a JSON con formato legible
            string json = JsonUtility.ToJson(wrapper, true);

            // Obtener la ruta del archivo en la carpeta persistente
            string rutaArchivo = Path.Combine(Application.persistentDataPath, nombreArchivo);

            // Escribir el archivo
            File.WriteAllText(rutaArchivo, json);

            Debug.Log($"Lista de puntos 2D guardada exitosamente en: {rutaArchivo}");
            Debug.Log($"Contenido JSON:\n{json}");
        }
        catch (System.Exception e)
        {
            Debug.LogError($"Error al guardar puntos 2D: {e.Message}");
        }
    }

    internal List<Estudiante> CargarEstudiantesJSON()
    {
        throw new NotImplementedException();
    }

    internal List<punto2D> CargarPuntos2DJSON()
    {
        throw new NotImplementedException();
    }

    [System.Serializable]
    public class EstudiantesWrapper
    {
        public List<Estudiante> estudiantes;
    }

    [System.Serializable]
    public class PuntosWrapper
    {
        public List<punto2D> puntos;
    }
}
