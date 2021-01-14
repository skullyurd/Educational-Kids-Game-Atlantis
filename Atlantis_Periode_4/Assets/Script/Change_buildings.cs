using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_buildings : MonoBehaviour
{

    public bool dag;

    public GameObject destroyed;
    public GameObject still_ok;

    void Update()
    {
        if(dag == false)
        {
            destroyed.SetActive(true);
            still_ok.SetActive(false);
        }
        else
        {
            destroyed.SetActive(false);
            still_ok.SetActive(true);
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            dag = false;
        }
    }
}
