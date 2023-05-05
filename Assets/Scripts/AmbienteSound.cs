using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Collections;

public class AmbienteSound : MonoBehaviour
{
    //public AudioClip ambientSound;
    //public float startDelay;
    
    private AudioSource audioSource;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.time = 3f;
        audioSource.Play();
    }
}
