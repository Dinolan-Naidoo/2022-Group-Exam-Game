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
    
    // Start is called before the first frame update
    void Start()
    {
        
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
            endGamePanel.SetActive(true);
            endGameText.text = "WELL DONE YOU HAVE REACHED THE END!";
        }
    }
}
