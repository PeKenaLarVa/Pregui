using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
  public static AudioController instance;

  public AudioSource pickupFlower;
  public AudioSource flowerBorn;
  public AudioSource grunt;
  public AudioSource musicMarimba;
  public AudioSource musicPad;
  public AudioSource musicBass;
  public AudioSource musHouse;
  public AudioSource sfxForest;


  private void Awake()
  {
    instance = this;
  }

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void PlayPickupFlower()
  {
    pickupFlower.Play();
  }

  public void PlayFlowerBorn()
  {
    flowerBorn.Play();
  }

  public void PlayGrunt()
  {
    grunt.Play();
  }

  public void PlayMusMarimba()
  {
    musicMarimba.Play();
  }

  public void PlayMusPad()
  {
    musicPad.Play();
  }

  public void PlayMusBass()
  {
    musicBass.Play();
  }

  public void PlayMusHouse()
  {
    musHouse.Play();
  }

  public void PlaySfxForest()
  {
    sfxForest.Play();
  }
  




}
