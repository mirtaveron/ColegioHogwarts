using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alumno : MonoBehaviour
{
    private int idAlumno;
    private string nombreAlumno;
    private string apellidoAlumno;
    private int nroLegajoAlumno;

    private Casa casa;
    private List<Materia> inscripto;
    private List<Materia> cursadas;
    private List<Materia> aprobadas;

    public Alumno(string nombre, string apellido, int legajo)
    {
        nombreAlumno = nombre;
        apellidoAlumno = apellido;
        nroLegajoAlumno = legajo;
    }

    public void getAlumno(int id)
    {
       
        //idAlumno = alumno.idAlumno;
        //nombreAlumno = alumno.nombreAlumno;
        //apellidoAlumno = alumno.apellidoAlumno;
        //nroLegajoAlumno = alumno.nroLegajoAlumno;
        //casa = alumno.casa;
        //inscripto = alumno.inscripto;
        //cursadas = alumno.cursadas;
        //aprobadas = alumno.aprobadas;
    }

    public void eliminarAlumno()
    {
        
    }
    
    public List<Materia> getMateriasInscripto()
    {
        return inscripto;
    }

    public List<Materia> getMateriasCursadas()
    {
        return cursadas;
    }

    public List<Materia> getMateriasAprobadas()
    {
        return aprobadas;
    }

    public void setMateriasInscripto(List<Materia> materias)
    {
        inscripto = materias;
    }

    public void setMateriasCursadas(List<Materia> materias)
    {
        cursadas = materias;
    }

    public void setMateriasAprobadas(List<Materia> materias)
    {
        aprobadas = materias;
    }

   

}
