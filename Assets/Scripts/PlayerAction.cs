using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public GameObject flashLight;

    bool isFlashlightOn = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isFlashlightOn = !isFlashlightOn;

            if (isFlashlightOn)
            {
                flashLight.SetActive(true);
            } else
            {
                flashLight.SetActive(false);
            }
        }
    }
}