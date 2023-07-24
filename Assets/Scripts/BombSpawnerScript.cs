using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawnerScript : MonoBehaviour
{
<<<<<<<< Updated upstream:Assets/Scripts/WatermelonSpawnerScript.cs
    public GameObject watermelon;
========
    public GameObject bomb;
>>>>>>>> Stashed changes:Assets/Scripts/BombSpawnerScript.cs
    public float spawnRate = 1.5f;
    private float timer = 0;
    public float spawnRadiaus = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > spawnRate) {
<<<<<<<< Updated upstream:Assets/Scripts/WatermelonSpawnerScript.cs
            spawnWatermelon();
========
            spawnBomb();
>>>>>>>> Stashed changes:Assets/Scripts/BombSpawnerScript.cs
            timer = 0;
        }
        timer += Time.deltaTime;
    }

<<<<<<<< Updated upstream:Assets/Scripts/WatermelonSpawnerScript.cs
    void spawnWatermelon()
    {
        float leftSpawnPoint = transform.position.x - spawnRadiaus;
        float rightSpawnPoint = transform.position.x + spawnRadiaus;
        Instantiate(watermelon, new Vector3(
========
    void spawnBomb()
    {
        float leftSpawnPoint = transform.position.x - spawnRadiaus;
        float rightSpawnPoint = transform.position.x + spawnRadiaus;
        Instantiate(bomb, new Vector3(
>>>>>>>> Stashed changes:Assets/Scripts/BombSpawnerScript.cs
            Random.Range(leftSpawnPoint, rightSpawnPoint),
            transform.position.y,
            transform.position.z
            ),transform.rotation);
    }
}
