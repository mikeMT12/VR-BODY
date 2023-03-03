using System;
using System.Collections.Generic;
using UnityEngine;

public class HandForTriggers : MonoBehaviour
{
    [SerializeField] private GameManagerForTriggers _gameManager;
    [SerializeField] private GameObject[] _points; // Точки для задевания
    [SerializeField] private float _timeToGetDressed = 10f;
    [SerializeField] private float _nowTime;
    public int stage = 0; // Стадия 
    
    public GameObject[] points => _points;

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
        
        if (other.gameObject.GetComponent<PointForTriggers>())
        {
            _points[stage].SetActive(false);
            stage += 1;
            _gameManager.Check();
            
            if (stage != _points.Length)
            {
                _points[stage].SetActive(true);
            }
        }
    }

    private void Reset()
    {
        _nowTime = 0;
        stage = 0;
        
        foreach (var t in _points)
        {
            t.gameObject.SetActive(false);
        }
        
        _points[stage].SetActive(true);
    }
}
