using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cenarioInfinito : MonoBehaviour
{
    public float VelocidadeDoCenario;

    // Update is called once per frame
    void Update()
    {
        MovimentarCenario();
    }

    private void MovimentarCenario()
    {
        Vector2 deslocamentoDoCenario = new Vector2(1f, Time.time * VelocidadeDoCenario);
        GetComponent<Renderer>().material.mainTextureOffset = deslocamentoDoCenario;
    }
}
