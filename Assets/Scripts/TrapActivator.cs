using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapActivator : MonoBehaviour
{
    public PlayerController player;

    //void Start()
    //{
    //    StartCoroutine(DelaySpike());
    //}

    public void SlowPlayer()
    {
        StartCoroutine(Slowed());
    }

    public IEnumerator DelaySpike()
    {
        yield return new WaitForSeconds(2.5f);
        SlowPlayer();
    }

    public IEnumerator Slowed()
    {
        yield return new WaitForSeconds(0.1f);
        Debug.Log("test slow");
        //player.playerSpeed = 2f;
        //yield return new WaitForSeconds(1f);
        //player.playerSpeed = 7.5f;
    }
}
