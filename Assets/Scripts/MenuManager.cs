using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Button[] difficultyButtons;

    void Start()
    {
        for (int i = 0; i < difficultyButtons.Length; i++)
        {
            int difficulty = i;
            difficultyButtons[i].onClick.AddListener(() => StartGame(difficulty));
        }
    }

    void StartGame(int difficulty)
    {
        PlayerPrefs.SetInt("Difficulty", difficulty);
        SceneManager.LoadScene("Habitacion");
    }
}