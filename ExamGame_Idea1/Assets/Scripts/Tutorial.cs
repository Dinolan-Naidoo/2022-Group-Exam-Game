using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI instructionText;
    [SerializeField] private GameObject instructionPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(gameObject.name);
    }

 /*   // Update is called once per frame
    void Update()
    {
        
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Player here");
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Climbing is the slowest form of movement.");
            instructionPanel.SetActive(true);
            instructionText.text = "Climbing is the slowest form of movement. Time jumps and land perfectly to avoid climbing.";
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Climbing is the slowest form of movement.");
            instructionPanel.SetActive(false);
            //instructionText.text = "Climbing is the slowest form of movement.";
        }
    }

}
