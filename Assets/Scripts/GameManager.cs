using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int cardsToSpawn = 0;
    public int dificulty = 0;
    public CardSpawner cardSpawner;
    public CardInteractionController cardInteractionController;
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
    }

    void Update()
    {
        Debug.Log(difficulty);
    }
    public void SendCardsToSpawn(int amount)
    {
        cardSpawner.CreateMatrix(amount);
    }
    
    public void OnPairMismatch()
    {
        lifeController.DecreaseLife();
    }

    public void GameOver()
    {

    }
}
