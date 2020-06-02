using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kulka : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject kuleczka;
    public Material[] kolory;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal")* Time.deltaTime * speed;
        //print(x);
        float y = Input.GetAxis("Vertical")*Time.deltaTime*speed;
        //print(y);
        transform.Translate(x, y, 0);

        if(Input.GetMouseButtonDown(0))
        {
            int kolor = Random.Range(0, kolory.Length);
            kuleczka.transform.GetComponent<Renderer>().material = kolory[kolor];
            //print(Input.mousePosition.x + "   " + Input.mousePosition.y);
            Vector3 pozycja = Input.mousePosition;
            pozycja.z = 15f;
            pozycja = Camera.main.ScreenToWorldPoint(pozycja);
            Instantiate(kuleczka, pozycja, Quaternion.identity);
        }
    }
}
