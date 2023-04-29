using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCartas : MonoBehaviour
{
    public int filas; // El número de filas en la matriz
    public int columnas; // El número de columnas en la matriz
    public GameObject objeto; // El objeto que se instanciará
    public List<GameObject> listaPrefabs;  //ACA SOLO HAY 3 CARTAS
    private GameObject[] objetos; // El array de objetos que se instanciarán

    // Start is called before the first frame update
    void Start()
    {
        objetos = new GameObject[filas * columnas];
        
        int contadorCartas = 0;
        if ((filas * columnas) % 2 == 0)
        {
            for (int i = 0; i < filas * columnas; i++)
            {
                objetos[i]= listaPrefabs[contadorCartas];
                if (contadorCartas == 2)
                {
                    contadorCartas = 0;
                }
                contadorCartas++;
            }
        }

        /*---------------------------------------------------------------------------*/

        // Barajar la lista de objetos
        List<GameObject> objetosAleatorios = new List<GameObject>(objetos);
        Shuffle(objetosAleatorios);

        // Bucle para recorrer las filas de la matriz
        for (int fila = 0; fila < filas; fila++)
        {
            // Bucle para recorrer las columnas de la matriz
            for (int columna = 0; columna < columnas; columna++)
            {
                // Calcular la posición de la celda actual
                Vector3 posicion = new Vector3(fila + 4.87f, 0, columna + 0.93f);

                // Instanciar un objeto aleatorio en la posición actual
                //  GameObject nuevoObjeto = Instantiate(objetosAleatorios[0], posicion, Quaternion.identity);
                GameObject nuevoObjeto = Instantiate(objetosAleatorios[0], posicion, Quaternion.identity);

                // Quitar el objeto instanciado de la lista
                objetosAleatorios.RemoveAt(0);
            }
        }
    }

    // Función para barajar una lista de objetos aleatoriamente
    void Shuffle<T>(List<T> lista)
    {
        int n = lista.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = lista[k];
            lista[k] = lista[n];
            lista[n] = value;
        }
    }
    // Start is called before the first frame update
    /*
        void Start()
        {
            // Bucle para recorrer las filas de la matriz
            for (int fila = 0; fila < filas; fila++)
            {
                // Bucle para recorrer las columnas de la matriz
                for (int columna = 0; columna < columnas; columna++)
                {
                    // Calcular la posición de la celda actual
                    Vector3 posicion = new Vector3(fila, 0, columna);

                    // Instanciar un objeto en la posición actual
                    GameObject nuevoObjeto = Instantiate(objeto, posicion, Quaternion.identity);

                    // Asignar un nombre único al objeto
                    // nuevoObjeto.name = "Objeto (" + fila + "," + columna + ")";
                }
            }
        }
    */
    /*
    void Start()
    {
        // Recorrer los elementos de la lista de objetos
        for (int i = 0; i < objetosAInstanciar.Count; i++)
        {
            // Calcular la posición del objeto actual
            Vector3 posicion = new Vector3(i, 0, 0);

            // Instanciar el objeto actual en la posición calculada
            GameObject nuevoObjeto = Instantiate(objetosAInstanciar[i], posicion, Quaternion.identity);

            // Asignar un nombre único al objeto
            nuevoObjeto.name = "Objeto " + i;
        }
    }

    */
    // Update is called once per frame
    void Update()
    {

    }

}
