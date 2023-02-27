using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VV : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {

    
        if (other.gameObject.GetComponent<TZone>())
        {
            Debug.Log(4);
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
