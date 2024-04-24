using System;
using UnityEngine;

[Serializable]
public class WalkStateConfig
{
    [field: SerializeField, Range(0, 5)] public float WalkSpeed { get; private set; }
}
