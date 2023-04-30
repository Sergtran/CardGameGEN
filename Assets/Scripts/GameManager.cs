using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CrearCartas crearCartas;
    public EliminarCartas eliminarCartas;
    public LifeController lifeController;
    private int difficulty;

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if (instance != this)
        {
            if (instance != null)
            {
                DestroyImmediate(instance.gameObject);
            }
        }
        instance = this;

    }
    void Start()
    {        
        if (PlayerPrefs.HasKey("Difficulty"))
        {
            difficulty = PlayerPrefs.GetInt("Difficulty");
        }
        switch (difficulty)
        {
            case 0:
                crearCartas.InstanciarCartas(1,8);

                break;
            case 1:
                crearCartas.InstanciarCartas(2, 8);

                break;
            case 2:
                crearCartas.InstanciarCartas(3, 8);
                break;
            default:
                Debug.LogError("Invalid difficulty value!");
                break;
        }
    }

    void Update()
    {
        
    }
  
    
    public void OnPairMismatch()
    {
        lifeController.DecreaseLife();
    }

    public void GameOver()
    {
        Debug.Log("you lose");
        eliminarCartas.gameObject.SetActive(false);
    }

    public void YouWin()
    {
        Debug.Log("you win");
        eliminarCartas.gameObject.SetActive(false);
    }
}
