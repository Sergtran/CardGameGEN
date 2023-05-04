using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitController : MonoBehaviour
{
    public void CerrarJuego()
    {
        Application.Quit();
        Debug.Log("Salir");
    }
}

