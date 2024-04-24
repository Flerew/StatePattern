public class FastRunningState : GroundedState
{
    private readonly FastRunningStateConfig _config;

    public FastRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.FastRunningStateConfig;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.FastSpeed;

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
        else if (IsPressCtrl()) 
            StateSwitcher.SwitchState<FastRunningState>();
        else
            StateSwitcher.SwitchState<RunningState>();
    }
}
