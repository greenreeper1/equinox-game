using UnityEngine;

public class AugmentManager : MonoBehaviour
{

    public PlayerData playerStats;

    public AugmentData[] allAugments;
    public AugmentUI[] slots;

    public bool canDoubleShot = false;
    public bool canBackShot = false;
    public bool canProjectileBounce = false;

    public void ApplyAugment(AugmentData augment)
    {
        augment.augmentType.Apply(playerStats, augment.value);
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
