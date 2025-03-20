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
        if (startDeath)
        {
            timer += Time.deltaTime;
            if (timer >= timeTillDeath)
            {
                Destroy(gameObject);
            }
        }
    }

    public void SendOff()
    {
        startDeath = true;
    }
}
