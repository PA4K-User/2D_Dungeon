using UnityEngine;

[CreateAssetMenu(fileName = "WeaponShootEffect_", menuName = "Scriptable Objects/Weapons/Weapon Shoot Effect")]
public class WeaponShootEffectSO : ScriptableObject
{
    [Space(10)]
    [Header("WEAPON SHOOT EFFECT DETAILS")]
    public Gradient colourGradiant;
    public float duration = 0.50f;
    public float startParticleSize = 0.25f;
    public float startParticleSpeed = 3f;
    public float startLifeTime = 0.5f;
    public int maxParticleNumber = 100;
    public int emissionRate = 100;
    public int burstParticleNumber = 20;
    public float effectGravity = -0.01f;
    public Sprite sprite;
    public Vector3 velocityOverLifetimeMin;
    public Vector3 velocityOverLifetimeMax;
    public GameObject weaponShootEffectPrefab;

    #region Validation
#if UNITY_EDITOR
    private void OnValidate()
    {
        HelperUtilities.ValidateCheckPositiveValue(this, nameof(duration), duration, false);
        HelperUtilities.ValidateCheckPositiveValue(this, nameof(startParticleSize), startParticleSize, false);
        HelperUtilities.ValidateCheckPositiveValue(this, nameof(startParticleSpeed), startParticleSpeed, false);
        HelperUtilities.ValidateCheckPositiveValue(this, nameof(startLifeTime), startLifeTime, false);
        HelperUtilities.ValidateCheckPositiveValue(this, nameof(maxParticleNumber), maxParticleNumber, false);
        HelperUtilities.ValidateCheckPositiveValue(this, nameof(emissionRate), emissionRate, false);
        HelperUtilities.ValidateCheckPositiveValue(this, nameof(burstParticleNumber), burstParticleNumber, false);
        HelperUtilities.ValidateCheckNullValue(this, nameof(weaponShootEffectPrefab), weaponShootEffectPrefab);
    }
#endif
    #endregion
}
