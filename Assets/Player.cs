using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;

    private int health = 10;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока" + health);


    }

    public void CollectCoins()
    {


        coins++;

        print("Собрание монетки: " + coins);
    }
}
