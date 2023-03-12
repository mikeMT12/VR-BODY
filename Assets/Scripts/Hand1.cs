using System;
using System.Collections.Generic;
using UnityEngine;

public class Hand1 : MonoBehaviour
{
    public GameObject[] points;
    [SerializeField] private Hand1 _leftHand;
    [SerializeField] private Hand1 _rightHand;
    [SerializeField] private GameManager1 gameManager;


    public int stage = 0;

    private void OnTriggerEnter(Collider other)
    {
        
        gameManager.nowTime = 0;
        //if (points.Contains(other.name))
        //if (other.gameObject.GetComponent<PointForTriggers>())
        foreach (GameObject zone in _leftHand.points)
        {
            Debug.Log(zone.tag);
            int index = Array.IndexOf(_leftHand.points, zone);
            //if(other.gameObject.tag == zone.gameObject.tag)
            if (index == _leftHand.stage)
            {
                points[stage].SetActive(false);
                stage += 1;
                gameManager.SetStage();
            }
        }
        foreach (GameObject zone1 in _rightHand.points)
        {
            Debug.Log(zone1.name);
            int index1 = Array.IndexOf(_rightHand.points, zone1);
            Debug.Log(index1);
            //if (other.gameObject.tag == zone1.gameObject.tag)
            if(index1 == _rightHand.stage)
            {
                points[stage].SetActive(false);
                stage += 1;

                gameManager.SetStage();
            }
        }

    }
}
