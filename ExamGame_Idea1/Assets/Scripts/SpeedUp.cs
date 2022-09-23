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

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {

           StartCoroutine (PickUp(collision));

        }

    }

    IEnumerator PickUp(Collider2D player)
    {


        Player_Controller speed_ =player.GetComponent<Player_Controller>();
        speed_.speed += 15f;


        yield return new WaitForSeconds(2f);

        speed_.speed -= 15f;

        Destroy(gameObject);
    }


}
