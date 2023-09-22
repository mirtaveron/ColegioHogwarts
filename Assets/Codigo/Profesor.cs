using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profesor : MonoBehaviour
{
    private int idProfesor;
    public string nombreProfesor;
    public string apellidoProfesor;
    public string nroLegajoProfesor;

    public List<Materia> materias;

    public Profesor(string nombre, string apellido, string legajo)//, List<Materia> listaMaterias)
    {
        nombreProfesor = nombre;
        apellidoProfesor = apellido;
        nroLegajoProfesor = legajo;
       // materias = listaMaterias;
    }

    public void getProfesor(int id)
    {
        
        //idProfesor = profesor.idProfesor;
        //nombreProfesor = profesor.nombreProfesor;
        //apellidoProfesor = profesor.apellidoProfesor;
        //nroLegajoProfesor = profesor.nroLegajoProfesor;
        //materias = profesor.materias;
    }

    public List<Materia> getMateriasProfesor()
    {
        return materias;
    }

    public void setMateriasProfesor(List<Materia> listaMaterias)
    {
        materias = listaMaterias;
    }

    public void eliminarProfesor()
    {
       
    }
}
