public class WalkState : GroundedState
{
    private readonly WalkStateConfig _config;

    public WalkState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.WalkStateConfig;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.WalkSpeed;

        View.StartRunning();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopRunning();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
        else if(IsPressShift())
            StateSwitcher.SwitchState<FastRunningState>();
        else
            StateSwitcher.SwitchState<RunningState>();
    }
}
