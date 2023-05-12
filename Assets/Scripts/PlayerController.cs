using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text scoreText;
    public Text winText;

    private Rigidbody rb;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        score = 0;
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");
        var movement = new Vector3(moveHorizontal,0,moveVertical);
        rb.AddForce(movement*speed);

        if(transform.position.y < -10)
        {
            SceneManager.LoadScene("game");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            score = score+1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        scoreText.text = "Count" + score.ToString();

        if(score >=1)
        {
            winText.text = "You Win";
        }
    }
}
