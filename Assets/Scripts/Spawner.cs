using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Asteroide1; // Objeto a ser spawnado
    public GameObject Asteroide2; // Objeto a ser spawnado
    public GameObject Gema;
    public Transform spawnPoint; // Ponto de spawn dos objetos
    public float minSpawnInterval = 1f; // Intervalo m�nimo de tempo entre os spawns
    public float maxSpawnInterval = 4f; // Intervalo m�ximo de tempo entre os spawns

    private float timer = 0f; // Timer para controlar o intervalo entre os spawns
    private float spawnInterval; // Intervalo de tempo atual entre os spawns

    private void Start()
    {
        // Define o intervalo de spawn inicial
        SetRandomSpawnInterval();
    }

    private void Update()
    {
        // Incrementa o timer
        timer += Time.deltaTime;

        // Verifica se o tempo de spawn foi alcan�ado
        if (timer >= spawnInterval)
        {
            // Reseta o timer
            timer = 0f;

            // Realiza o spawn do objeto
            SpawnObject();

            // Define um novo intervalo de spawn aleat�rio
            SetRandomSpawnInterval();
        }
    }

    private void SpawnObject()
    {
        // Instancia o objeto a ser spawnado no ponto de spawn
        Instantiate(Asteroide1, spawnPoint.position, spawnPoint.rotation);
        Instantiate(Asteroide2, spawnPoint.position, spawnPoint.rotation);
        Instantiate(Gema, spawnPoint.position, spawnPoint.rotation);
    }

    private void SetRandomSpawnInterval()
    {
        // Define um novo intervalo de spawn aleat�rio entre minSpawnInterval e maxSpawnInterval
        spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
    }
}
