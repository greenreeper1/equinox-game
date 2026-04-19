using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AugmentUI : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public Image icon;

    private AugmentData currentAugment;
    private AugmentManager augmentManager;

    public void Setup(AugmentData augment, AugmentManager manager)
    {
        currentAugment = augment;
        augmentManager = manager;

        nameText.text = augment.augmentName;
        descriptionText.text = augment.description;
        icon.sprite = augment.icon;
    }

    public void OnClick()
    {
        augmentManager.ApplyAugment(currentAugment);
    }
}
