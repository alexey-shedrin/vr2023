using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ForCube : MonoBehaviour
{
    public float speed = 10f;
    public int a;
    public int b;
    public int c;
    public GameObject sphere;
    public Text x;
    public GameObject bcam;
    public GameObject cam;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 5 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5 * speed * Time.deltaTime);
        }
        if (c <= 0)
        {
            bcam.SetActive(false);
            cam.SetActive(true);
            this.gameObject.SetActive(false);
            x.text = "Game Over";
        }
        else x.text = c.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("cen");
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        c--;
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("cs");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("cet");
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("te");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("tx");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("ts");
    }
    public void heal()
    {
        c = 5;
    }
}
