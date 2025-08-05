using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using packagePersona;
using packagePunto2D;

public static class Utilidades
{
    // Ruta fija de guardado 
    private static readonly string carpetaDestino = "D:/Users/nicolns.rojas/Documents/GitHub/Proyecto_G52_Game/ProyGith_Unity/Assets/JSON";

    //  guardar lista Estudiantes en JSON
    public static void GuardarEstudiantesEnJSON(List<Estudiante> listaE, string nombreArchivo)
    {
        EstudianteWrapper wrapper = new EstudianteWrapper();
        wrapper.estudiantes = listaE;

        string json = JsonUtility.ToJson(wrapper, true); // JSON bonito
        string ruta = Path.Combine(carpetaDestino, nombreArchivo + "_Estudiante.json");

        File.WriteAllText(ruta, json);
        Debug.Log(" Estudiantes guardados en: " + ruta);
    }

    //  guardar lista Punto2D en JSON
    public static void GuardarPuntosEnJSON(List<Punto2D> listaP, string nombreArchivo)
    {
        Punto2DWrapper wrapper = new Punto2DWrapper();
        wrapper.puntos = listaP;

        string json = JsonUtility.ToJson(wrapper, true);
        string ruta = Path.Combine(carpetaDestino, nombreArchivo + "_Punto2D.json");

        File.WriteAllText(ruta, json);
        Debug.Log(" Puntos 2D guardados en: " + ruta);
    }

    // Wrappers - serialización de listas
    [Serializable]
    private class EstudianteWrapper
    {
        public List<Estudiante> estudiantes;
    }

    [Serializable]
    private class Punto2DWrapper
    {
        public List<Punto2D> puntos;
    }
}
