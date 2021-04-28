using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycleManager : MonoBehaviour
{
    [Range(0, 1)]
    public float TimeOfDay;
    public float DayDuration = 60f;

    public AnimationCurve SunCurve;

    public Light Sun;

    public GameObject[] Lights = null;

    private float sunIntensity;


    // Start is called before the first frame update
    void Start()
    {
        sunIntensity = Sun.intensity;
        TimeOfDay = 0.25f;
        foreach(GameObject go in Lights)
        {
            Light light = go.GetComponent<Light>();
            if(light != null)
            {
                light.enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        TimeOfDay += Time.deltaTime / DayDuration;
        if (TimeOfDay >= 1) TimeOfDay -= 1;
        if (TimeOfDay >= 0.5f)
        {
            foreach (GameObject go in Lights)
            {
                Light light = go.GetComponent<Light>();
                if (light != null)
                {
                    light.enabled = true;
                }
            }

        }
        else
        {
            foreach (GameObject go in Lights)
            {
                Light light = go.GetComponent<Light>();
                if (light != null)
                {
                    light.enabled = false;
                }
            }
        }

        Sun.transform.localRotation = Quaternion.Euler(TimeOfDay * 360f, 180, 0);
        Sun.intensity = sunIntensity * SunCurve.Evaluate(TimeOfDay);

    }
}
