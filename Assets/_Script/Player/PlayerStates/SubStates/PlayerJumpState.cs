using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : PlayerAbilityState
{
    private int amountOfjumpLeft;

    public PlayerJumpState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
        amountOfjumpLeft = playerData.amountOfJump;
    }

    public override void Enter()
    {
        base.Enter();

        player.SetVelocityY(playerData.jumpVelocity);
        isAbilityDone = true;
        amountOfjumpLeft--;
        player.InAirState.SetIsJumping();
    }

    public bool CanJump()
    {
        if(amountOfjumpLeft > 0)
            return true;
        return false;
    }

    public void ResetAmountOfJumpLeft() => amountOfjumpLeft = playerData.amountOfJump;
    public void DecreaseAmountOfJumpLeft() => amountOfjumpLeft--;
}
