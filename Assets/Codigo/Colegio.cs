using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colegio : MonoBehaviour
{
    private int idColegio;
    private string nombreColegio;

    private Profesor director;
    private Profesor codirector;

    public Colegio(string nombre)
    {
        nombreColegio = nombre;
    }

    public void getColegio(int id)
    {
       
        //idColegio = colegio.idColegio;
        //nombreColegio = colegio.nombreColegio;
        //director = colegio.director;
        //codirector = colegio.codirector;
    }

    public void setDirector(Profesor profesor)
    {
        director = profesor;    
    }

    public void setCodirector(Profesor profesor)
    {
        codirector = profesor;
    }

}
