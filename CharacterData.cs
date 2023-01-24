using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Create Character Data", fileName ="New Character Data")]
public class CharacterData : ScriptableObject
{

    public new string name;

    public int maxHP;
    public int maxMP;
    public int maxSP;

    public GameObject battler;
}
