using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escena : MonoBehaviour
{
    public void CambiarEscena(int indice)
    {
        SceneManager.LoadScene(indice);
    }
}
