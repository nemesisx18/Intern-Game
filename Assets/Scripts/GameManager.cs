using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] trap;
    public GameObject[] trap2;

    float elapsedTime = 0f; // Counts up to repeatTime
    float repeatTime = 4f; // Time taken to repeat in seconds

    private int currentIndex = 0;
    private int currentIndex2 = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= repeatTime)
        {
            // Do something here
            RandomSpike();
            // Subtract repeat time
            elapsedTime -= repeatTime;
        }
    }

    public void RandomSpike()
    {
        int newIndex = Random.Range(0, trap.Length);
        int newIndex2 = Random.Range(0, trap2.Length);
        
        // Deactivate old gameobject
        trap[currentIndex].SetActive(false);
        trap2[currentIndex2].SetActive(false);

        // Activate new gameobject
        currentIndex = newIndex;
        currentIndex2 = newIndex2;
        trap[currentIndex].SetActive(true);
        trap2[currentIndex2].SetActive(true);
    }
}


