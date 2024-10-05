using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_IncreaseSpeed : PowerUp
{
    public override void ApplyEffect(GameObject player)
    {
        if (player.gameObject.name == "Player 1")
        {
            player.GetComponent<Player1Controller>().speed += 5f;
            player.GetComponent<Player1Controller>().StartCoroutine(RevertEffect(player));

        }
        else
        {
            player.GetComponent<Player2Controller>().speed += 5f;
            player.GetComponent<Player2Controller>().StartCoroutine(RevertEffect(player));
        }
    }

    IEnumerator RevertEffect(GameObject player)
    {
        yield return new WaitForSeconds(5f);
        if (player.gameObject.name == "Player 1")
        {
            player.GetComponent<Player1Controller>().speed -= 5f;
        }
        else
        {
            player.GetComponent<Player2Controller>().speed -= 5f;

        }
    }
}
