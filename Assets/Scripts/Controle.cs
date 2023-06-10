using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour
{
    public Rigidbody2D oRigidbody2D;

    public GameObject laser;
    public Transform LaserSpaw;

    public float VelocidadeDaNave;

    public float timeMaxEntreLaser;
    public float timeAtualLaser;

    public bool playerAtirador;

    private Vector2 teclasApertadas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarJogador();

        if (playerAtirador == true)
        {
            AtirarLaiser();
        }
    }

    private void MovimentarJogador()
    {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        oRigidbody2D.velocity = teclasApertadas * VelocidadeDaNave;
    }

    private void AtirarLaiser()
    {
        timeAtualLaser -= Time.deltaTime;

        if(timeAtualLaser <= 0)
        {
            Instantiate(laser, LaserSpaw.position, Quaternion.Euler(0f, 0f, 0f));
            timeAtualLaser = timeMaxEntreLaser;
        }
    }
}
