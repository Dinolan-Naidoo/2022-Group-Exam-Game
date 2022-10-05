using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndGame : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI endGameText;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject endGamePanel;
    [SerializeField] private GameObject controlsPanel;
    [SerializeField] private GameObject hudPanel;

    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    /*// Update is called once per frame
    void Update()
    {
        
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("GAME OVER");
            player.SetActive(false);
            hudPanel.SetActive(false);
            controlsPanel.SetActive(false);
            endGamePanel.SetActive(true);
            if (gameManager.playerInLead)
            {
                endGameText.text = "WELL DONE YOU WON THE RACE!";
            }
            else
            {
                endGameText.text = "SADLY YOU LOST THE RACE :(";
            }
            
        }
    }
}
