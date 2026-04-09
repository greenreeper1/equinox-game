using UnityEngine;
using UnityEngine.UI;
public class TimerUI : MonoBehaviour
{

    public Timer timer;
    public Image barImage;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer == null)
        {
            return;
        }

        float progress = timer.GetProgress();
        barImage.fillAmount = 1f - progress;
    }
}
