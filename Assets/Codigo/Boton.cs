using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public AudioSource miSonido;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    public void HoverSound(){
       miSonido.PlayOneShot(hoverSound);
    }

    public void ClickSound(){
       miSonido.PlayOneShot(clickSound);
    }
}
