using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSceneTriggers : MonoBehaviour
{
    [SerializeField] private GameObject _camera;
    public GameObject _player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<HandForTriggers>())
        {
            //_camera.gameObject.SetActive(false);
            _player.GetComponent<Animator>().Play("GetInTHeCar");
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
