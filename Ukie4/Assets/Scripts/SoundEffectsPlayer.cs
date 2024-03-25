using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    public AudioSource Src;
    public AudioClip sfx1, Sfx2, Sfx3;


    public void ButtonPressSound()
    {
        Src.clip = sfx1;
        Src.Play();

    }

    //public void Button2() 
    //{

    //    Src.clip = Sfx2;
    //    Src.Play();

    //}

    //public void Button3()
    //{

    //    Src.clip = Sfx3;
    //    Src.Play();

    //}





}
