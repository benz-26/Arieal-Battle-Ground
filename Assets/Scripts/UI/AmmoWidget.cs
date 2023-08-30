using UnityEngine;

public class AmmoWidget : MonoBehaviour
{
    [SerializeField] private int maxAmmo;
    [SerializeField] private int minAmmo;
    [SerializeField] private int minClip;
    [SerializeField] private int maxClip;
    public TMPro.TMP_Text ammoText;
    public TMPro.TMP_Text clipText;

    // Use properties for better encapsulation
    public int MaxAmmo { get => maxAmmo; }
    public int MinAmmo { get => minAmmo; }
    public int MinClip { get => minClip; }
    public int MaxClip { get => maxClip; }

    public void Refresh(int ammoCount, int clipCount)
    {
        // Use Mathf.Clamp to ensure values are within the specified range
        int clampedAmmoCount = Mathf.Clamp(ammoCount, minAmmo, maxAmmo);
        int clampedClipCount = Mathf.Clamp(clipCount, minClip, maxClip);

        // Use string interpolation for formatting text
        ammoText.text = $"{clampedAmmoCount}";
        clipText.text = $"{clampedClipCount}";
    }
}
