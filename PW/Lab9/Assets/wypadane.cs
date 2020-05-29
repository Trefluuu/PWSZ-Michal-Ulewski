using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wypadane : MonoBehaviour
{
    public GameObject[] obiekt;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerujObiekty", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("WCIŚNIĘTO ENTER!");
            print("KONIEC LOSOWANIA");
            CancelInvoke("GenerujObiekty");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("WCIŚNIĘTO SPACJĘ - GENERUJE LOSOWY OBIEKT");
            GenerujObiekty();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("WCIŚNIĘTO 1 - KAPSULA 2");
            Instantiate(obiekt[0], transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            print("WCIŚNIĘTO 2 - KAPSULA 1");
            Instantiate(obiekt[1], transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            print("WCIŚNIĘTO 3 - CYLINDER");
            Instantiate(obiekt[2], transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            print("WCIŚNIĘTO 4 - KULA 2");
            Instantiate(obiekt[3], transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            print("WCIŚNIĘTO 5 - KULA 1");
            Instantiate(obiekt[4], transform.position, Quaternion.identity);
        }

    }
    void GenerujObiekty()
    {
        int los = Random.Range(0, obiekt.Length);
        Instantiate(obiekt[los], transform.position, Quaternion.identity);
    }
}
