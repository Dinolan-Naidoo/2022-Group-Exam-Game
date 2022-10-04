using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject currentPlayer;
    [SerializeField] private GameObject otherPlayer;
    [SerializeField] private TextMeshProUGUI positionText;

    /* // Start is called before the first frame update
     void Start()
     {

     }*/

    // Update is called once per frame
    void Update()
    {
        CheckPosition();
    }
    
    private void CheckPosition()
    {
        if (currentPlayer.transform.position.x>otherPlayer.transform.position.x)
        {
            //Debug.Log("player 1 in lead");
            positionText.text = "Position: 1/2";
        }
        else
        {
            //Debug.Log("player 2 in lead");
            positionText.text = "Position: 2/2";
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
