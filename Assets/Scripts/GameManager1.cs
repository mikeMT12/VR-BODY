using System;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    [SerializeField] private Hand1 _leftHand;
    [SerializeField] private Hand1 _rightHand;

    public float nowTime;
    public float timeToGetDressed = 10f;

    public void SetStage()
    {
        if ((_leftHand.stage == _rightHand.stage) && 
            (_leftHand.stage != _leftHand.points.Length)  && (_leftHand.stage != _rightHand.points.Length))
        {
            _leftHand.points[_leftHand.stage].SetActive(true);
            _rightHand.points[_rightHand.stage].SetActive(true);
        }
    }

    public void Reset()
    {
        nowTime = 0;
        _leftHand.stage = 0;
        _rightHand.stage = 0;
        
        foreach (var t in _leftHand.points)
        {
            t.gameObject.SetActive(false);
        }
        
        foreach (var t in _rightHand.points)
        {
            t.gameObject.SetActive(false);
        }
        
        _leftHand.points[_leftHand.stage].SetActive(true);
        _rightHand.points[_rightHand.stage].SetActive(true);
    }

    private void Start()
    {
        Reset();
    }

    private void Update()
    {
        nowTime += Time.deltaTime;

        if (nowTime >= timeToGetDressed)
        {
            Reset();
        }
    }
}
