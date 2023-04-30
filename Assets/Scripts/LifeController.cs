using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeController : MonoBehaviour
{
    public int inicialLife = 5;
    public int currentLife;
    public Image lifeImage;
    public Sprite[] lifeSprites;
    private bool isMatch;

    void Start()
    {
        currentLife = inicialLife;   
        //lifeImage.sprite = lifeSprites[currentLife - 1];   

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentLife);
    }

    public void DecreaseLife()
    {

        // bool isMatch = CompareCards(); // Llamamos a la función que devuelve un bool
         // Si el resultado es falso
        
            currentLife--; // Restamos una vida

            if (currentLife < 1)
            {
                GameManager.Instance.GameOver();
            }
            else
            {
                //lifeImage.sprite = lifeSprites[currentLife - 1];
            }
        
    }
}


