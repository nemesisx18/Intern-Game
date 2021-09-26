using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] trap;
    
    float elapsedTime = 0f; // Counts up to repeatTime
    float repeatTime = 2f; // Time taken to repeat in seconds
    
    private int currentIndex = 0;
    
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
        
        // Deactivate old gameobject
        trap[currentIndex].SetActive(false);
        
        // Activate new gameobject
        currentIndex = newIndex;
        trap[currentIndex].SetActive(true);
    }

}
