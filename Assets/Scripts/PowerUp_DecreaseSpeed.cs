using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_DecreaseSpeed : PowerUp
{
    public override void ApplyEffect(GameObject player)
    {
        GameObject opponent = player.gameObject.name == "Player 1" ? GameObject.FindWithTag("Player2") : GameObject.FindWithTag("Player1");

        if (player.gameObject.name == "Player 1")
        {
            GameObject.FindWithTag("Player2").GetComponent<Player2Controller>().speed -= 5f;
            opponent .GetComponent<Player2Controller>().StartCoroutine(RevertEffect(opponent ));
        }
        else
        {
            GameObject.FindWithTag("Player1").GetComponent<Player1Controller>().speed -= 5f;
            opponent .GetComponent<Player1Controller>().StartCoroutine(RevertEffect(opponent ));
        }
    }

    IEnumerator RevertEffect(GameObject player)
    {
        yield return new WaitForSeconds(5f);
        if (player.gameObject.name == "Player 1")
        {
            player.GetComponent<Player1Controller>().speed += 5f;
        }
        else
        {
            player.GetComponent<Player2Controller>().speed -= 5f;

        }
    }
}
