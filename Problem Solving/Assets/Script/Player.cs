using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float increase = 0.5f;
    private bool isGameOver = false;

    [Header("UI")]
    public UIgameover GameOverUI;

    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            transform.localScale -= new Vector3(increase, increase, increase);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            isGameOver = true;
            GameOverUI.Show();
            Time.timeScale = 0;
        }
    }
    void GameOver()
    {
        Vector3 local = transform.localScale;

        if (transform.localScale.y < 1)
        {
            isGameOver = true;
            GameOverUI.Show();
            Time.timeScale = 0;
        }
    }
}
