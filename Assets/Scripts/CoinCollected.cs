using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class CoinCollected : MonoBehaviour
{
    public bool isInRange;
    public UnityEvent interactAction;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            interactAction.Invoke();
            ScoreScript.scoreValue = ScoreScript.scoreValue + 1;
            Destroy(gameObject);
        }
    }

}
