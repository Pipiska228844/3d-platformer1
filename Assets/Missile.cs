using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{ 
    public float speed = 10f;
    // Start is called before the first frame updat
    void Start()
    {
    Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
{
    transform.position +=
    transform.forward *
    speed * Time.deltaTime;
}

   void OntriggerEnter(Collider other) {
    Destroy(gameObject);
    Enemy enemy = other.GetComponent<Enemy>();
    Destroy(enemy);


    
}

}
