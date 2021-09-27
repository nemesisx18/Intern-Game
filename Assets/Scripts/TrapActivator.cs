using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapActivator : MonoBehaviour
{
    public PlayerController player;

    void Update()
    {
        StartCoroutine(DelaySpike());
    }

    void SlowPlayer()
    {
        StartCoroutine(player.Slowed());
    }

    IEnumerator DelaySpike()
    {
        yield return new WaitForSecondsRealtime(2.5f);
        SlowPlayer();
    }

    //IEnumerator Slowed()
    //{
    //    player.playerSpeed = 2f;
    //    yield return new WaitForSeconds(1f);
    //    player.playerSpeed = 5f;
    //}
}
