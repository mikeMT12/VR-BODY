using System;
using System.Collections.Generic;
using UnityEngine;

public class Hand1 : MonoBehaviour
{
    public GameObject[] points;
    [SerializeField] private GameManager1 gameManager;
    public int stage = 0;
    
    private void OnTriggerEnter(Collider other)
    {
        gameManager.nowTime = 0;
        //if (points.Contains(other.name))
        //if (other.gameObject.GetComponent<PointForTriggers>())
        foreach (GameObject zone in points)
        {
            if(zone.name == other.name)
            {
                points[stage].SetActive(false);
                stage += 1;

                gameManager.SetStage();
            }
        }

    }
}
