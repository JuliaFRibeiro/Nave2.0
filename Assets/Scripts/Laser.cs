using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float velocidadeLaser;
    public float destroyDelay = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyAfterDelay());
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarLaser();
    }

    private void MovimentarLaser()
    {
        transform.Translate(Vector3.up * velocidadeLaser * Time.deltaTime);
    }

    private IEnumerator DestroyAfterDelay()
    {
        // Aguarda o tempo de autodestruição
        yield return new WaitForSeconds(destroyDelay);

        // Destroi o objeto
        Destroy(gameObject);
    }
}
