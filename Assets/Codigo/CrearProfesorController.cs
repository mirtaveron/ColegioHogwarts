using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CrearProfesorController : MonoBehaviour
{
    // Referencias a los componentes de la UI
    public Dropdown listaDropdown;
    public TMP_Text nombreInput;
    public TMP_Text apellidoInput;
    public TMP_Text legajoInput;
    public Button crearButton;


    public static List<Profesor> profesores;

    

    // Start is called before the first frame update
   /* void Start()
    {
        // Inicializar la lista de profesores solo si es nula
        if (profesores == null)
        {
            profesores = new List<Profesor>();
        }

        // Agregar un listener al botón para que llame al método CrearObjeto cuando se presione
        crearButton.onClick.AddListener(CrearProfesor);

        // Agregar un listener al dropdown para que llame al método MostrarDetalles cuando se cambie la opción seleccionada
      //  listaDropdown.onValueChanged.AddListener(MostrarDetalles);


    }
   */
    public void CrearProfesor()
    {
        // Obtener los valores de los inputs
        string nombre = nombreInput.text;
        string apellido  = apellidoInput.text;
        string legajo = legajoInput.text;

 //Debug.Log(nombre + apellido + legajo);
        // Validar que no estén vacíos
        if (nombre == "" || apellido == "" || legajo == "")
        {
           
            // Mostrar un mensaje de error en el área de detalles
            // detallesText.text = "Por favor, ingrese un nombre, apellido y legajo válidos.";
            return;
        }

        // Crear un nuevo objeto vacío
        // GameObject objeto = new GameObject();

        // Asignarle el nombre y el color ingresados
        // objeto.name = nombre;
        // objeto.GetComponent<Renderer>().material.color = Color.Parse(color);

        // Inicializar la lista de profesores solo si es nula
        if (profesores == null)
        {
            profesores = new List<Profesor>();
        }

        // Crear un nuevo profesor con los atributos ingresados
        Profesor profesor = new Profesor(nombre, apellido, legajo);

        // Agregar el profesor a la lista estática
        profesores.Add(profesor);

       Debug.Log(profesores);

        // Agregar el nombre del profesor al dropdown
        //listaDropdown.options.Add(new Dropdown.OptionData(nombre));

        // Mostrar un mensaje de éxito en el área de detalles
        //detallesText.text = "Se ha creado el profesor " + nombre + " con el color " + color + ".";
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
