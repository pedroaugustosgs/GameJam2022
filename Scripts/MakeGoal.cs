using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MakeGoal : MonoBehaviour
{
    [SerializeField] private GameObject _endGoalText;
    //[SerializeField] private GameObject _deadtext;
    [SerializeField] private GameObject _playerBlue, _playerRed;
 
    private bool _reset = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _reset)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Fim de jogo
            _endGoalText.SetActive(true);
            _reset = true;

            // Desativando controles do player
            Destroy(_playerBlue.GetComponent<PlayerMoviment>());
            //Destroy(_playerRed.GetComponent<PlayerMoviment>());
        }
    }
}
