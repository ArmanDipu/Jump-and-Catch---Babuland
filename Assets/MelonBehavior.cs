using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonBehavior : MonoBehaviour
{
    public Rigidbody2D melonRigidbody2D;
    private Collider2D melonCollider2D;
    private GameManager gamemanager;
    public float lifeTime = 7f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        melonCollider2D = GameObject.FindGameObjectWithTag("hasCatchCollider2D").GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == melonCollider2D)
        {
            Debug.Log("Melon Caught");
            Destroy(gameObject);
            gamemanager.addScore();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > lifeTime)
        {
            Destroy(gameObject);
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
