using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarCartas : MonoBehaviour
{
    /*
 void OnMouseDown()
    {
        // Crea un rayo desde la cámara hasta la posición del cursor del mouse
        Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Si el rayo intersecta con un objeto, envía un mensaje al Controlador con información sobre el objeto
        if (Physics.Raycast(rayo, out hit))
        {
            // Obtiene el GameObject del objeto seleccionado
            GameObject objetoSeleccionado = hit.collider.gameObject;

            // Envía un mensaje al Controlador con información sobre el objeto seleccionado
            SendMessage("InformacionObjeto", objetoSeleccionado);
        }
    }
*/

  void OnMouseDown()
    {
        // Crea un rayo desde la cámara hasta la posición del cursor del mouse
        Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Si el rayo intersecta con un objeto, obtiene información sobre él
        if (Physics.Raycast(rayo, out hit))
        {
            // Obtiene el GameObject al que se ha accedido
            GameObject objeto = hit.collider.gameObject;

            // Obtiene el nombre del objeto y lo imprime en la consola
            string nombre = objeto.name;
            Debug.Log("El objeto seleccionado es: " + nombre);

            // Obtiene la posición del objeto y lo imprime en la consola
            Vector3 posicion = objeto.transform.position;
            Debug.Log("La posición del objeto es: " + posicion);
        }
    }
    
}
