using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float life = 3;

    void Awake()
    {
        Destroy(gameObject, life);
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
}
