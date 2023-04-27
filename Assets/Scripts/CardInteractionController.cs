using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInteractionController : MonoBehaviour
{
    private bool itIsMatch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //unasr el mouse y un rycast para seleccionar las cartas
    }

    void SelectCard()
    {
        //metodo q selecciona y compara cartas
        //se necesita un bool si las cartas son paraje true sino false
        if (itIsMatch)
        {

        }
        else
        {
            GameManager.Instance.OnPairMismatch();
        }
    }
}
