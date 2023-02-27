using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TriggersRealTime : MonoBehaviour
{
    public List<GameObject> TriggerZones = new List<GameObject>();
    public List<GameObject> TriggerObjects = new List<GameObject>();
    private int currentActiveIndex = 0; 

/*    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.GetComponent<TriggerObjectsCollides>())
        {
            Debug.Log(4);
        }
    }*/
    
    void Start()
    {
        for( int i = 0; i < TriggerZones.Count; i++)
        {
            TriggerZones[currentActiveIndex].SetActive(false);
            currentActiveIndex += 1;
        }
        currentActiveIndex = 0;
        TriggerZones[currentActiveIndex].SetActive(true);
        TriggerZones[currentActiveIndex + 1].SetActive(true);
        Debug.Log(TriggerObjects[0].name);
        
    }

    
    void Update()
    {
        
    }
}
