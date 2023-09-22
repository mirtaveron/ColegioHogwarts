using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CrearMateriaController : MonoBehaviour
{

    public TMP_InputField nombreInput;
    public TMP_Dropdown listaProfesoresDropdown;   
    public Button crearButton;
    public TMP_Text mensaje;
    
    public static List<Materia> materias;
    Dictionary<string, string> profesoresDiccionario = new Dictionary<string, string>();

    
    void Start()
    {
        
        if (CrearProfesorController.profesores == null)
        {
            CrearProfesorController.profesores = new List<Profesor>();
        }

        foreach (Profesor profesor in CrearProfesorController.profesores)
        {
            
            listaProfesoresDropdown.options.Add(new TMP_Dropdown.OptionData(profesor.nombreProfesor + " " + profesor.apellidoProfesor));
            profesoresDiccionario.Add(profesor.nombreProfesor + " " + profesor.apellidoProfesor, profesor.nroLegajoProfesor);
                
        }

        listaProfesoresDropdown.value = 0; 
        listaProfesoresDropdown.Select(); 
        listaProfesoresDropdown.RefreshShownValue(); 

        listaProfesoresDropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(listaProfesoresDropdown); });
    }



    void DropdownItemSelected(TMP_Dropdown dropdown)
    {

        int index = dropdown.value;
        listaProfesoresDropdown.SetValueWithoutNotify(index);
        listaProfesoresDropdown.RefreshShownValue();
               
    }


    public void CrearMateria()
    {
        
        
        string legajo;
        
        if (string.IsNullOrWhiteSpace(nombreInput.text))
        {
            mensaje.text = "Debe ingresar un nombre de materia";
        }
        else if (listaProfesoresDropdown.options.Count == 0)
        {
            mensaje.text = "Debe asignar un profesor";
        }
        else
        {
            string nombreApellidoProfesor = listaProfesoresDropdown.options[listaProfesoresDropdown.value].text;
            profesoresDiccionario.TryGetValue(nombreApellidoProfesor, out legajo);

            Profesor profesor = CrearProfesorController.profesores.Find(p => p.nroLegajoProfesor == legajo);

            Materia materia = new Materia(nombreInput.text, profesor);
            materias.Add(materia);

            mensaje.text = "";
        }
    }
  
}
