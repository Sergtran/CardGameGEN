using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public int inicialLife;
    public int currentLife;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseLife()
    {
        //codigo con logica para perde vida

        if (currentLife==0)
        {
            GameManager.Instance.GameOver();
        }
    }
}
