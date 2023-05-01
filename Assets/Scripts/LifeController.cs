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
    public AudioSource audioSource;


    void Start()
    {
        currentLife = inicialLife;
        //lifeImage.sprite = lifeSprites[currentLife - 1];   
        audioSource = GameObject.Find("SoundMachete").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentLife);
    }

    public IEnumerator DecreaseLife()
    {

        // bool isMatch = CompareCards(); // Llamamos a la función que devuelve un bool
        // Si el resultado es falso

        currentLife--; // Restamos una vida

        yield return new WaitForSeconds(5f);
        audioSource.Play();

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


