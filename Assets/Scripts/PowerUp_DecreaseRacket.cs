using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_DecreaseRacket : PowerUp
{
    public override void ApplyEffect(GameObject player)
    {
        GameObject opponent = player.gameObject.name == "Player 1" ? GameObject.FindWithTag("Player2") : GameObject.FindWithTag("Player1");
        opponent.transform.localScale -= new Vector3(0, 1f, 0); // Decrease opponent's racket height
        
        if (opponent.gameObject.name == "Player 1")
        {
            opponent.GetComponent<Player1Controller>().StartCoroutine(RevertEffect(opponent));
        }
        else
        {
            opponent.GetComponent<Player2Controller>().StartCoroutine(RevertEffect(opponent));
        }
    }

    IEnumerator RevertEffect(GameObject opponent)
    {
        yield return new WaitForSeconds(5f);
        Debug.Log("revert");
        opponent.transform.localScale += new Vector3(0, 1f, 0); // Revert size after 5 seconds
    }
}
