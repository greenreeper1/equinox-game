using UnityEngine;

public class AugmentManager : MonoBehaviour
{

    public PlayerStats playerStats;

    public AugmentData[] allAugments;
    public AugmentUI[] slots;

    public bool canDoubleShot = false;
    public bool canBackShot = false;
    public bool canProjectileBounce = false;

    public void ApplyAugment(AugmentData augment)
    {
        Debug.Log(playerStats);
        Debug.Log(augment.value);
        Debug.Log(augment.augmentType);
        augment.augmentType.Apply(playerStats.runtimeData, augment.value);
    }

    public void ShowAugments()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            AugmentData randomAugment = allAugments[Random.Range(0, allAugments.Length)];
            slots[i].Setup(randomAugment, this);
        }
    }
}
