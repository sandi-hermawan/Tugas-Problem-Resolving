

using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text scaleText;

    public float increase;
    int score;
    float scale = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        scaleText.text = scale.ToString();
        BackScale();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            transform.localScale += new Vector3(increase, increase, increase);
            Destroy(collision.gameObject);
            score++;
            scale += increase;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {

            scale -= 0.5f;
    }
        
    }
    void BackScale()
    {
        Vector3 local = transform.localScale;

        if (Input.GetKeyDown("space") && transform.localScale.y > 1)
        {
            transform.localScale -= new Vector3(increase, increase, increase);
        }
    }

}
