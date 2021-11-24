using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading;

public class InteractionManager : MonoBehaviour
{
    public static AudioClip deathSound, coinCollect, winSound;
    static AudioSource audioSrc;
    
    void Start()
    {
        //Grabs the audio clips for various sounds
        deathSound = Resources.Load<AudioClip>("death");
        coinCollect = Resources.Load<AudioClip>("coin");
        winSound = Resources.Load<AudioClip>("win");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlayDeath()
    {
        //Plays death sound, pauses game for death audio, and refreshes level
        audioSrc.PlayOneShot(deathSound);
        Thread.Sleep(750);
        SceneManager.LoadScene("Scene_Play_Game");

    }

    public static void PlayCoin()
    {
        //plays coin sound
        audioSrc.PlayOneShot(coinCollect);

    }

    public static void PlayWin()
    {
        //Plays win sound, pauses game for win audio, loads credit/win scene
        audioSrc.PlayOneShot(winSound);
        Thread.Sleep(1500);
        SceneManager.LoadScene("Scene_Winner");

    }


}
