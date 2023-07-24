using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class BombBehavior : MonoBehaviour
{
    public Rigidbody2D bombRigidbody2D;
    private Collider2D BombCollider2D;
    private GameManager gamemanager;
    public float lifeTime = 5f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        gamemanager= GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        BombCollider2D = GameObject.FindGameObjectWithTag("hasBombCollider2D").GetComponent<Collider2D>();
        bombRigidbody2D.velocity = new Vector2(Random.Range(-2f, 2f), bombRigidbody2D.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == BombCollider2D)
        {
            Debug.Log("Explosion!");
            Destroy(gameObject);
            gamemanager.redeuceHealth();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > lifeTime)
        {
            Destroy(gameObject);
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
