using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WinLoseMenuController : MonoBehaviour
{
    public Button resetButton;
    public Button menuButton;
    public GameObject winImage;
    public GameObject loseImage;
    public GameObject pauseButton;
    public Image handImage;

    public void ResetLevel()
    {
        resetButton.gameObject.SetActive(false);
        menuButton.gameObject.SetActive(false);
        winImage.gameObject.SetActive(false);
        loseImage.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(true);
        handImage.gameObject.SetActive(true);

    }

    public void win()
    {
        resetButton.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);
        winImage.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        handImage.gameObject.SetActive(false);
    }    
    public void lose()
    {
        resetButton.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);
        loseImage.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        handImage.gameObject.SetActive(false);
    }

}
