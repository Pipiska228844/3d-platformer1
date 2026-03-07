using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int coins;
    public AudioSource audioSource;
    private int health = 10;
    public AudioClip damageSound;
    public void TakeDamage(int damage)
    {
        health -= damage;
       if(health > 0) 
    {
       audioSource.PlayOneShot(damageSound);
    }
     else
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
    
    
    
    }

    public void CollectCoins()
    {


        coins++;

        print("�������� �������: " + coins);
    }
}
