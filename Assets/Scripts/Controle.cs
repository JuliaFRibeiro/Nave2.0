using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour
{
    public FixedJoystick moveJoystick;
    public Rigidbody2D oRigidbody2D;
    private float moveH, moveV, speedMove= 5;

    public GameObject laser;
    public Transform LaserSpaw;

    public float VelocidadeDaNave;

    public float timeMaxEntreLaser;
    public float timeAtualLaser;

    public bool playerAtirador;

    // Start is called before the first frame update
    void Start()
    {
        oRigidbody2D = GetComponent <Rigidbody2D>();
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
        moveH = moveJoystick.Horizontal;
        moveV = moveJoystick.Vertical;
        Vector2 dir = new Vector2(moveH, moveV);
        oRigidbody2D.velocity = new Vector3(moveH * speedMove, oRigidbody2D.velocity.y, moveV* speedMove);
        if (dir != Vector2.zero) 
        {
            transform.LookAt(transform.position);
        }
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
