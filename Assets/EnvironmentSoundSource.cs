using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class EnvironmentSoundSource : MonoBehaviour
{
    public static AudioSource instance;

    private void Awake()
    {
        instance = GetComponent<AudioSource>();
    }

    void Start()
    {
        
    }
}
