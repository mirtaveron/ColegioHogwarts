using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MateriaController : MonoBehaviour
{
    public TMP_Dropdown listaMateriasDropdown;
    public TMP_Text nombreProfesor;

    void Start()
    {

        if (CrearMateriaController.materias == null)
        {
            CrearMateriaController.materias = new List<Materia>();
        }

        foreach (Materia materia in CrearMateriaController.materias)
        {

            listaMateriasDropdown.options.Add(new TMP_Dropdown.OptionData(materia.nombreMateria));

           // profesoresDiccionario.Add(profesor.nombreProfesor + " " + profesor.apellidoProfesor, profesor.nroLegajoProfesor);
        }

        listaMateriasDropdown.value = 0;
        listaMateriasDropdown.Select();
        listaMateriasDropdown.RefreshShownValue();
             
        if (listaMateriasDropdown.options.Count > 0)
        {
            string nombre = listaMateriasDropdown.options[0].text;
            Materia materiaPrimera = CrearMateriaController.materias.Find(m => m.nombreMateria == nombre);
            nombreProfesor.text = materiaPrimera.profesor.nombreProfesor + " " + materiaPrimera.profesor.apellidoProfesor;
        }

        listaMateriasDropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(listaMateriasDropdown); });
    }



    void DropdownItemSelected(TMP_Dropdown dropdown)
    {

        int index = dropdown.value;
        listaMateriasDropdown.SetValueWithoutNotify(index);
        listaMateriasDropdown.RefreshShownValue();

        string nombre = dropdown.options[dropdown.value].text;
        Materia materia = CrearMateriaController.materias.Find(m => m.nombreMateria == nombre);

        nombreProfesor.text = materia.profesor.nombreProfesor + " " + materia.profesor.apellidoProfesor;
        
    }

}
