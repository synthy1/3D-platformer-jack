using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sfx : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Audio")]
    public AudioClip[] deathsounds;
    AudioSource deathsound;
    public AudioSource gaurdexpo;
    AudioSource hit;
    AudioSource blood;
    AudioSource button;

    private void Start()
    {
        deathsound = GameObject.Find("death").GetComponent<AudioSource>();
        gaurdexpo = GameObject.Find("guard expo").GetComponent<AudioSource>();
        hit = GameObject.Find("hit").GetComponent<AudioSource>();
        blood = GameObject.Find("blood").GetComponent<AudioSource>();
        button = GameObject.Find("button").GetComponent<AudioSource>();
    }
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
