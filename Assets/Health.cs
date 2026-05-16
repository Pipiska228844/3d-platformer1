using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public AudioSource audioSource;
    public int maxHealth = 10;
    public int currenthealth = 10;
    public AudioClip damageSound;
    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        if (currenthealth > 0)
        {
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}