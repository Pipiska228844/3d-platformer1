using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallAttack : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform attackPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballprefab, attackPoint.position, attackPoint.rotation);

        }
    }
}    