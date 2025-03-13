using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    Transform hourPivot, minutePivot, secondPivot;
    float hourToDeg = -30;
    float secAndMinToDeg = -6;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan currTime = DateTime.Now.TimeOfDay;
        hourPivot.localRotation =
            Quaternion.Euler(0f, 0f, hourToDeg * (float) currTime.TotalHours);
        minutePivot.localRotation =
            Quaternion.Euler(0f, 0f, secAndMinToDeg * (float)currTime.TotalMinutes);
        secondPivot.localRotation =
            Quaternion.Euler(0f, 0f, secAndMinToDeg * (float)currTime.TotalSeconds);
    }
}
