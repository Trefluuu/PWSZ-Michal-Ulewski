using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{

    public float speed = 10.0f;
    private float translation;
    private float straffe;
    public float time = 0;
    public Text startText;
    public Text koniecText;
    public Text czasText;
    public Text iloscText;
    public bool startTime = false;
    public int ilosc = 0;

    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
            // turn on the cursor
            Cursor.lockState = CursorLockMode.None;
        }
        if (startTime = true) 
        { 
        time += Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Badge")
        {
            Destroy(collision.gameObject);
            ilosc++;
        }
        if (collision.gameObject.tag == "Meta")
        {
            koniecText.text = "KONIEC";
            startTime = false;
            czasText.text = "Czas: " + (time).ToString("0");
            iloscText.text = "Ilosc odznak: " + (ilosc).ToString("0");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Start")
        {
            startText.text = "START";
            Destroy(startText, 1);
            startTime = true;
        }
    }
}



