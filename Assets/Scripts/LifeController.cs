using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeController : MonoBehaviour
{
    public int initialLife = 5;
    public int currentLife;
    public Image lifeImage;
    public Sprite[] lifeSprites;
    public AudioSource audioSource;

    private void Start()
    {
        currentLife = initialLife;

        if (lifeImage != null && lifeSprites != null && lifeSprites.Length > currentLife - 1)
        {
            lifeImage.sprite = lifeSprites[currentLife - 1];
        }

        audioSource = GameObject.Find("SoundMachete")?.GetComponent<AudioSource>();
    }

    public IEnumerator DecreaseLife()
    {
        currentLife--;

        yield return new WaitForSeconds(5f);

        if (audioSource != null)
        {
            audioSource.Play();
        }
        if (lifeImage != null && lifeSprites != null && lifeSprites.Length > currentLife - 1)
        {
            lifeImage.sprite = lifeSprites[currentLife - 1];
        }

        if (currentLife < 1)
        {
            GameManager.Instance.GameOver();
        }


    }
}