using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float bulletSpeed = 20f;


    void Start()
    {
        rb.AddForce(transform.up * bulletSpeed, ForceMode2D.Impulse);
        Destroy(gameObject,2f);
    }
}
