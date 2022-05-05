using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMMananger : MonoBehaviour
{
    private AudioSource _audiosource;


    void Awake()
    {
        _audiosource = GetComponent<AudioSource>();

    }

    // Start is called before the first frame update
    void Start()
    {
        _audiosource.Play();
    }

    public void StopBGM()
    {
        _audiosource.Stop();
    }
}
