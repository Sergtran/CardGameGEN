using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //public GameObject pauseMenuPanel;
    [SerializeField] private GameObject botonPause;
    [SerializeField] private GameObject menuPause;
    private bool juegoPausado = false;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GameObject.Find("AmbientSound").GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(juegoPausado)
            {
                Reanudar();
                audioSource.UnPause();
            } else
            {
                Pause();
                audioSource.Pause();
            }
        }
    }

    public void Pause()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        audioSource.Pause();
        botonPause.SetActive(false);
        menuPause.SetActive(true);
    }

    public void Reanudar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        botonPause.SetActive(true);
        menuPause.SetActive(false);
        audioSource.UnPause();
    }

    public void Reiniciar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        audioSource.Play();
    }

    public void Quit()
    {
        Debug.Log("Se cierra el juego");
        audioSource.Stop();
        SceneManager.LoadScene("Main Menu (Mobile)");
        //Application.Quit();
    }
}
