using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleControll : MonoBehaviour
{
    // Rigidbody 2D bola
    private Rigidbody2D rigidBody2D;

    // Besarnya gaya awal yang diberikan untuk mendorong bola
    public float xInitialForce;
    public float yInitialForce;
    float radius;
    public float speed;

    internal Vector2 TrajectoryOrigin;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();

        // Mulai game
        RestartGame();
        TrajectoryOrigin = Vector2.one.normalized;
        radius = transform.localScale.x / 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ResetBall()
    {
        // Reset posisi menjadi (0,0)
        transform.position = Vector2.zero;

        // Reset kecepatan menjadi (0,0)
        rigidBody2D.velocity = Vector2.zero;
    }
    void PushBall()
    {

        float x = Random.Range(0, -2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rigidBody2D.velocity = new Vector2(speed * x, speed * y);
    }
    void RestartGame()
    {
        // Kembalikan bola ke posisi semula
        ResetBall();

        // Setelah 2 detik, berikan gaya ke bola
        Invoke("PushBall", 2);
    }
}
