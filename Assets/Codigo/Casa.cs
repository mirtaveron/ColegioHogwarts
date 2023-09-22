using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casa : MonoBehaviour
{
    private int idCasa;
    private string nombreCasa;
    private int puntos;

    private Profesor director;
    private List<Alumno> alumnos;

    public void getCasa(int id)
    {
        //idCasa = casa.idCasa;
        //nombreCasa = casa.nombreCasa;
        //puntos = casa.puntos;
    }


    public void setDirector(Profesor profesor)
    {
        director = profesor;
    }

    public List<Alumno> getAlumnos()
    {
        return alumnos;
    }

    public void setAlumnos(List<Alumno> listaAlumnos)
    {
        alumnos = listaAlumnos;
    }

    public void eliminarAlumno(int id)
    {
        
    }

}
