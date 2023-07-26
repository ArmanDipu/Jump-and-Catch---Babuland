using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonSpawnerScript : MonoBehaviour
{
    public GameObject melon;
    public float spawnRate = 1.5f;
    private float timer = 0;
    public bool isRightSpawner = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnRate)
        {
            spawnMelon();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void spawnMelon()
    {
        GameObject obj = (GameObject) Instantiate(melon, new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z), 
            transform.rotation
            );
        if(!isRightSpawner)
        {
            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(7,11), Random.Range(7,11));
        }
        else
        {
            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-7, -11), Random.Range(7, 11));
        }
    }
}
