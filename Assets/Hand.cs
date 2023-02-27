using System;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField] private GameObject[] _points; // Точки для задевания
    [SerializeField] private float _timeToGetDressed = 10f;
    [SerializeField] private float _nowTime;
    private int _stage = 0; // Стадия 

    private void Start()
    {
        Reset();
    }

    private void Update()
    {
        _nowTime += Time.deltaTime;

        if (_nowTime >= _timeToGetDressed)
        {
            Reset();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _nowTime = 0;
        
        if (other.gameObject.GetComponent<Point11>())
        {
            _points[_stage].SetActive(false);
            _stage += 1;
            
            if (_stage != _points.Length)
            {
                _points[_stage].SetActive(true);
            }
        }
    }

    private void Reset()
    {
        _nowTime = 0;
        _stage = 0;
        
        foreach (var t in _points)
        {
            t.gameObject.SetActive(false);
        }
        
        _points[_stage].SetActive(true);
    }
}
