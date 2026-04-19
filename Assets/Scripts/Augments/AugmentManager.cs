using UnityEngine;

public class AugmentManager : MonoBehaviour
{

    public PlayerData playerStats;

    public AugmentData[] allAugments;
    public AugmentUI[] slots;

    public void ApplyAugment(AugmentData augment)
    {
        switch (augment.augmentType)
        {
            case AugmentType.Damage:
                playerStats.damage *= (1 + augment.multiplier);
                break;
            default:
                break;
        }
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
