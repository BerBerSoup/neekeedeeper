using UnityEngine;

[CreateAssetMenu(menuName = "BerBerSoup/Data Enemy")]
public class DataEnemy : MonoBehaviour
{
    [Header("�����g��Ⱦ��v"), Range(0, 1)]
    public float expProbability;
    [Header("�����g��ȹw�s��")]
    public GameObject prefabExp;
}
