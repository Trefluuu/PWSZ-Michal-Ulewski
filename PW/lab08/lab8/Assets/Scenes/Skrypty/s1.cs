using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s1 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] szukane = GameObject.FindGameObjectsWithTag("kula");
        foreach (GameObject szukany in szukane)
            GameObject.Destroy(szukany);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
