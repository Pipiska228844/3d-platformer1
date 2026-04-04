using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)

 {
    Player player = other.GetComponent<Player>();

    player.CollectCoins();
 }
}
