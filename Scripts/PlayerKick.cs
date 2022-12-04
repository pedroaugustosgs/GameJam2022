using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKick : MonoBehaviour
{
    private bool _canshoot = true;
    private bool _canshootBall = false;

    [SerializeField] private GameObject _ball;
    private Rigidbody2D _rigidBody;

    // Update is called once per frame
    void awake()
    {
        _rigidBody = _ball.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.X) && _canshootBall) 
        {
            _rigidBody.AddForce(transform.up * 100f, ForceMode2D.Force);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball")) 
        {
            // Fim de jogo
            _canshootBall= true;
            //Destroy(collision.gameObject);
            // Desativando controles do player

            //_reset = true;

        }
        else
        {
            _canshootBall= false;
        }
    }
}
