using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_IncreaseRacket : PowerUp
{
    public override void ApplyEffect(GameObject player)
    {
        player.transform.localScale += new Vector3(0, 1f, 0); // Increase racket height
        Debug.Log("power up start");

        if (player.gameObject.name == "Player 1")
        {
            player.GetComponent<Player1Controller>().StartCoroutine(RevertEffect(player));
        }
        else
        {
            player.GetComponent<Player2Controller>().StartCoroutine(RevertEffect(player));
        }
    }

    IEnumerator RevertEffect(GameObject player)
    {
        yield return new WaitForSeconds(5f);
        Debug.Log("power up revert");
        player.transform.localScale -= new Vector3(0, 1f, 0); // Revert racket height
    }
}
