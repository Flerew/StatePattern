using UnityEngine;

[CreateAssetMenu(fileName = "CharacterConfig", menuName = "Configs/CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private RunningStateConfig _runningStateConfig;
    [SerializeField] private FastRunningStateConfig _fastRunningStateConfig;
    [SerializeField] private AirborneStateConfig _airborneStateConfig;
    [SerializeField] private WalkStateConfig _walkStateConfig;

    public RunningStateConfig RunningStateConfig => _runningStateConfig;
    public FastRunningStateConfig FastRunningStateConfig => _fastRunningStateConfig;
    public AirborneStateConfig AirborneStateConfig => _airborneStateConfig;
    public WalkStateConfig WalkStateConfig => _walkStateConfig;
}
