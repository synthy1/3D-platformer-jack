using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sfx : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Audio")]
    public AudioClip[] deathsounds;
    public AudioSource deathsound;
    public AudioSource gaurdexpo;
    public AudioSource hit;
    public AudioSource blood;
    public AudioSource button;

    public void PlayDeath()
    {
        deathsound.clip = deathsounds[Random.Range(0, deathsounds.Length)];
        deathsound.Play();
    }
    public void PlayExpo()
    {
        gaurdexpo.Play();
    } 
    public void PlayHit()
    {
        hit.Play();
    } 
    public void PlayBlood()
    {
        blood.Play();
    } 
    public void Playutton()
    {
        button.Play();
    }
}
