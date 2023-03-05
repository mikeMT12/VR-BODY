using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSceneTriggers : MonoBehaviour
{
    [SerializeField] private GameObject _camera;
    [SerializeField] private GameObject _player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<HandForTriggers>())
        {

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
