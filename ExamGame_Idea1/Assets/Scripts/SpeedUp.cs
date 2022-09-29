using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{

    //private float timer = 5f;
    [SerializeField]
    private float speedUpTime = 1f;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("player must speed up");
            StartCoroutine(Speed(collision));

        }
    }

    IEnumerator Speed(Collision2D player)
    {

        Player_Controller speed_ =player.gameObject.GetComponent<Player_Controller>();
        speed_.speed += 10f;

        yield return new WaitForSeconds(speedUpTime);

        speed_.speed -= 10f;
    }


}
