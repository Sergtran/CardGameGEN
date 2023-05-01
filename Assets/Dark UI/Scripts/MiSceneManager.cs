using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiSceneManager : MonoBehaviour
{
    public string nombreEscenaACargar;

    public void CambiarEscena()
    {
        SceneManager.LoadScene(nombreEscenaACargar);
    }
}
