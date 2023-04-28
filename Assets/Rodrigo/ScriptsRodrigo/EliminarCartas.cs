using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarCartas : MonoBehaviour
{
    
    private RotarCarta[] currentSelection = new RotarCarta[2];

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

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            // Crea un rayo desde la cámara hasta la posición del cursor del mouse
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

            // Si el rayo intersecta con un objeto, obtiene información sobre él
            if (Physics.Raycast(rayo, out hit))
            {
                //// Obtiene el GameObject al que se ha accedido
                //GameObject objeto = hit.collider.gameObject;

                //// Obtiene el nombre del objeto y lo imprime en la consola
                //string nombre = objeto.name;
                //Debug.Log("El objeto seleccionado es: " + nombre);

                //// Obtiene la posición del objeto y lo imprime en la consola
                //Vector3 posicion = objeto.transform.position;
                //Debug.Log("La posición del objeto es: " + posicion);


                var selectedCard = hit.collider.gameObject.GetComponent<RotarCarta>();
                if (selectedCard != null)
                {
                    SelectCard(selectedCard);

                }
            }
        }
    }
    void SelectCard(RotarCarta selectedCard)
    {
        if (currentSelection[0] == null)
        {
            // Primer carta seleccionada
            currentSelection[0] = selectedCard;
            

        }
        else if (currentSelection[1] == null)
        {

            // Segunda carta seleccionada
            currentSelection[1] = selectedCard;
            // Comparar las dos cartas seleccionadas
            bool match = CompareCards(currentSelection[0], currentSelection[1]);
            if (match)
            {
                Debug.Log("son pareja");

                // Las dos cartas forman una pareja, ejecutar lógica de juego
            }
            else
            {
                Debug.Log("NO son pareja");

                // Las dos cartas no forman una pareja, ejecutar lógica de juego
            }
            // Limpiar la selección actual del usuario
            currentSelection[0] = null;
            currentSelection[1] = null;
        }
    }

    public bool CompareCards(RotarCarta card1, RotarCarta card2)
    {
        return card1.myName == card2.myName;
    }

}
