using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/BuildinType")]
public class BuildingTypeSO : ScriptableObject
{
    public string nameString;
    public Transform prefab;
}
