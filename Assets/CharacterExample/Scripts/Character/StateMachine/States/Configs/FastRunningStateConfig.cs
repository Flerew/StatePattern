using System;
using UnityEngine;

[Serializable]
public class FastRunningStateConfig
{
    [field: SerializeField, Range(10, 15)] public float FastSpeed { get; private set; }
}
