using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Materia : MonoBehaviour
{
    private int idMateria;
    public string nombreMateria;

    public Profesor profesor;
    private List<Alumno> alumnos;

    public Materia(string nombre, Profesor profesorMateria)
    {
        nombreMateria = nombre;
        profesor = profesorMateria;        
    }

    public void getMateria(int id)
    {
       
        //idMateria = materia.idMateria;
        //nombreMateria = materia.nombreMateria;
        //profesor = materia.profesor;
        //alumnos = materia.alumnos;
    }

    public List<Alumno> getAlumnos()
    {
        return alumnos;
    }

    public void eliminarMateria()
    {
       
    }

}
