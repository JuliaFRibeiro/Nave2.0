using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroi : MonoBehaviour
{
    public int score = 1;
    public GameObject fx;


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("tiro"))
        {
            Destroy(gameObject);
            Instantiate(fx, transform.position, Quaternion.identity);
        }
    }
}