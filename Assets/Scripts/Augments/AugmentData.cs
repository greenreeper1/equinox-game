using UnityEngine;

public enum AugmentType{
    Damage,
    AttackSpeed,
    HP,
    Armor,
    Dodge,
    MoveSpeed,
    LifeSteal,
    Special,
}

[CreateAssetMenu(fileName = "NewAugment", menuName = "Game/Augment")]
public class AugmentData : ScriptableObject
{
    public string augmentName;
    [TextArea] public string description;
    public Sprite icon;

    public AugmentType augmentType;
    public float multiplier;
}
