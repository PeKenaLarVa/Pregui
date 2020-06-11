using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource mus;
    public AudioClip[] musArray;

   void Awake()
    {
        mus = GetComponent<AudioSource>();
    }
    void Start()
    {
        //musMarimba = FindObjectOfType<AudioSource>();
        mus.loop = false;
       // musMarimba.clip = musMarimbaArray[Random.Range(0, musMarimbaArray.Length)];
       // musMarimba.PlayOneShot(musMarimba.clip);
    }
     
    private AudioClip GetRandomClip()
    {
        return musArray[Random.Range(0, musArray.Length)];
    }
    // Update is called once per frame
    void Update()
    {
        if (!mus.isPlaying)
        {
            mus.clip = GetRandomClip();
            mus.Play();
        }
    }
}
