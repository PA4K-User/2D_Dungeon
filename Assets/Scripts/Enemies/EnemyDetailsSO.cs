using UnityEngine;

[CreateAssetMenu(fileName = "EnemyDetails_", menuName = "Scriptable Objects/Enemy/EnemyDetails")]
public class EnemyDetailsSO : ScriptableObject
{
    [Space(10)]
    [Header("BASE ENEMY DETAILS")]
    public string enemyName;
    public GameObject enemyPrefab;
    public float chaseDistance = 50f;

    [Space(10)]
    [Header("ENEMY MATERIAL")]
    public Material enemyStandardMaterial;

    [Space(10)]
    [Header("ENEMY MATERIALIZE SETTINGS")]
    public float enemyMaterializeTime;
    public Shader enemyMaterializeShader;

    [ColorUsage(true, true)]
    public Color enemyMaterializeColor;

    #region Validation
#if UNITY_EDITOR
    private void OnValidate()
    {
        HelperUtilities.ValidateCheckEmptyString(this, nameof(enemyName), enemyName);
        HelperUtilities.ValidateCheckNullValue(this, nameof(enemyPrefab), enemyPrefab);
        HelperUtilities.ValidateCheckPositiveValue(this, nameof(chaseDistance), chaseDistance, false);
        HelperUtilities.ValidateCheckNullValue(this, nameof(enemyStandardMaterial), enemyStandardMaterial);
        HelperUtilities.ValidateCheckPositiveValue(this, nameof(enemyMaterializeTime), enemyMaterializeTime, true);
        HelperUtilities.ValidateCheckNullValue(this, nameof(enemyMaterializeShader), enemyMaterializeShader);
    }
#endif
    #endregion
}
