using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveAndRotate : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 direction;
    public float force = 1
        ;
    public float rotateSpeed = 180f;
    public float destroyDelay = 5f; // Tempo em segundos antes da autodestrui��o

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Inicia a contagem regressiva para autodestrui��o
        StartCoroutine(DestroyAfterDelay());
    }

    private void Update()
    {
        // Rota��o autom�tica
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        rb.AddForce(direction * force);
    }

    private IEnumerator DestroyAfterDelay()
    {
        // Aguarda o tempo de autodestrui��o
        yield return new WaitForSeconds(destroyDelay);

        // Destroi o objeto
        Destroy(gameObject);
    }
}