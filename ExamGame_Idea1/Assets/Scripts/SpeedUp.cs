using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{

    private float timer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("player must speed up");
            StartCoroutine(PickUp(collision));

        }
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("player must speed up");
           StartCoroutine (PickUp(collision));

        }

    }*/

    IEnumerator PickUp(Collision2D player)
    {


        Player_Controller speed_ =player.gameObject.GetComponent<Player_Controller>();
        speed_.speed += 15f;




        yield return new WaitForSeconds(2f);

        speed_.speed -= 15f;

        //Destroy(gameObject);
    }


}
