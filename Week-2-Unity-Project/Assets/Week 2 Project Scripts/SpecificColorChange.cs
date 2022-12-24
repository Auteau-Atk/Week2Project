using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecificColorChange : MonoBehaviour
{
    private bool switchColours = false;


    void Update()
    {
        ChangeMyColor();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(switchColours)
            {
                switchColours = false;
            }
            else
            {
                switchColours = true;
            }
        }
    }

    void ChangeMyColor()
    {
        if(switchColours)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
