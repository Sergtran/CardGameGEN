using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public int inicialLife = 5;
    public int currentLife;
    public Image lifeImage;
    public Sprite[] lifeSprites;

    void Start()
    {
        currentLife = inicialLife;   
        lifeImage.sprite = lifeSprites[currentLife - 1];   

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseLife()
    {
        
    bool isMatch = CompareCards(); // Llamamos a la función que devuelve un bool
    if (!isMatch) // Si el resultado es falso
    {
        currentLife--; // Restamos una vida
    
        if (currentLife == 0)
        {
            GameManager.Instance.GameOver();
        }
        else 
        {
            lifeImage.sprite = lifeSprites[currentLife - 1]
        }
    }
}


