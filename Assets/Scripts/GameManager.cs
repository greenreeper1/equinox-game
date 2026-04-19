using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Timer timer;
    public DayState currentState;
    public DayState previousState;
    public SpriteRenderer playerSprite;
    public AugmentManager augmentManager;

    private void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer.OnTimerEnd += SwitchDayState;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        if (timer  != null)
        {
            timer.StopTimer();
            timer.OnTimerEnd -= SwitchDayState;
        }
    }

    public void SwitchDayState()
    {
        if (currentState == DayState.DAY || currentState == DayState.NIGHT)
        {
            previousState = currentState;
            currentState = DayState.UPGRADING;
            augmentManager.ShowAugments();
            // TODO : Call the method to choose an upgrade
        }
        else if (currentState == DayState.UPGRADING)
        {
            if (previousState == DayState.DAY)
            {
                // The night awakes
                currentState = DayState.NIGHT;
                playerSprite.color = Color.white;
                timer.StartTimer();
                // TODO : Change Enemies and decor
            }
            else if (previousState == DayState.NIGHT)
            {
                // The day awakes
                currentState = DayState.DAY;
                playerSprite.color = Color.black;
                timer.StartTimer();
                // TODO : Change Enemies and decor
            }
        }
    }
}
