using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLight : MonoBehaviour
{
    public Light myLight;
    private bool isOn = false;
    private float intensityS, velocidad = 5, amplitud = 3;

    // Start is called before the first frame update
    void Start()
    {
        intensityS = myLight.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            myLight.intensity = intensityS + (Mathf.Sin(Time.time * velocidad) * amplitud);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isOn = !isOn;
        myLight.enabled = isOn;
    }

}
