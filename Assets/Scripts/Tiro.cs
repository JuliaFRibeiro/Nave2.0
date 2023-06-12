using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public int score = 1;
    public GameObject fx;

    public UIManager uimanager;

    private void Start()
    {
        uimanager = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(fx, transform.position, Quaternion.identity);
        }
    }
}