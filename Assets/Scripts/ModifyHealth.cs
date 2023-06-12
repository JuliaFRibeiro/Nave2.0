using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyHealth : MonoBehaviour
{
    public int damage = 1;
    public GameObject fx;

    UIManager uimanager;

    private void Start()
    {
        uimanager = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            uimanager.SetSLives(damage);
            Instantiate(fx, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }

    }

}