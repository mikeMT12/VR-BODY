using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trevoga : MonoBehaviour
{
    AudioSource trevoga;
    public float delay;
    public float timePlay;
    private float timePassed = 0;

    void Start()
    {
        trevoga = GetComponent<AudioSource>();
        trevoga.PlayDelayed(delay);
        timePlay += delay;
    }

    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed >= timePlay)
        {
            trevoga.Stop();
        }
    }
}
