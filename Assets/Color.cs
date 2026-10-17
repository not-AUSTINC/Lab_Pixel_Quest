using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorChanger : MonoBehaviour
{
    private Renderer playerRenderer;

    void Start()
    {
        playerRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerRenderer.material.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            playerRenderer.material.color = Color.blue;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            playerRenderer.material.color = Color.black;
        }
    }
}