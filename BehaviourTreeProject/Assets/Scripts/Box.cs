using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    bool startDeath;
    float timer;
    public float timeTillDeath;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startDeath) //start death timer
        {
            timer += Time.deltaTime;
            if (timer >= timeTillDeath)
            {
                Destroy(gameObject); //destroy game object after the specified time has passed
            }
        }
    }

    public void SendOff()
    {
        startDeath = true;
    }
}
