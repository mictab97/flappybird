using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLittleBird : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    private int _score;
    [SerializeField] private UIManager _uiManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
        rb.velocity = Vector2.up * velocity;
        } 
    }


    private void OnCollisioEnter2D(Collider2D collision)
    {
        gameManager.GameOver();
    }
    public void AddScore()
    {
        _score += 1;
        _uiManager.SetScoreText(_score);
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        AddScore();
    }
}
