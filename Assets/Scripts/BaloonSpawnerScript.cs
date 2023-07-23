using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatermelonSpawnerScript : MonoBehaviour
{
    public GameObject balloon;
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
            spawnBalloon();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void spawnBalloon()
    {
        float leftSpawnPoint = transform.position.x - spawnRadiaus;
        float rightSpawnPoint = transform.position.x + spawnRadiaus;
        Instantiate(balloon, new Vector3(
            Random.Range(leftSpawnPoint, rightSpawnPoint),
            transform.position.y,
            transform.position.z
            ),transform.rotation);
    }
}
