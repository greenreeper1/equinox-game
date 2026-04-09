using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    
    [SerializeField] float timerDuration = 1.5f * 60f; //wait 1.5 minutes
    private float timerTime = 0f;
    private bool isRunning = false;

    public Action OnTimerEnd;

    public float GetProgress()
    {
        return timerTime / timerDuration;
    }

    public void StartTimer()
    {
        timerTime = 0f;
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isRunning)
        {
            return;
        }
        timerTime += Time.deltaTime;
        if (timerTime > timerDuration)
        {
            StopTimer();
            OnTimerEnd?.Invoke();
        }
    }
}
