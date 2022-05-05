using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    private AudioSource _audioSource;
    public AudioClip deathSFX;
    public AudioClip goombaSFX;
    public AudioClip monedaSFX;
    public AudioClip banderaSFX;


    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
   
   public void DeathSound()
   {
       _audioSource.PlayOneShot(deathSFX);
   }

   public void GoombaSound()
   {
       _audioSource.PlayOneShot(goombaSFX);
   }

   public void CogerMoneda()
   {
       _audioSource.PlayOneShot(monedaSFX);
   }

   public void CogerBandera()
   {
       _audioSource.PlayOneShot(banderaSFX);
   }
   
}
