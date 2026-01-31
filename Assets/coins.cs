using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;
    public AudioSource audioSource;
    public AudioClip damageSound;
    public AudioClip collectSound;

    public void CollectCoins()
    {
     

        coins++;


        audioSource.PlayOneShot(collectSound);

 
        print("Собрание монетки: " + coins);
    }
}
