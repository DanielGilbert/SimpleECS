﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[AddComponentMenu("EntitySystem/PlayerInputSystem")]
public class PlayerInputSystem : EntitySystem<PlayerComponent, InputComponent>
{
	public float MoveSpeed = 8f;

	public string HorizontalInput = "Horizontal";
	public string VerticalInput = "Vertical";
	public string ShootInput = "Fire1";

	public override void InitializeSystem ()
	{
		isUpdateSystem = true;
	}

	public override void UpdateSystem (PlayerComponent player, InputComponent input)
	{
		input.xAxis = MoveSpeed * Input.GetAxis(HorizontalInput);
		input.yAxis = MoveSpeed * Input.GetAxis(VerticalInput);
		input.shoot = Input.GetButton(ShootInput);
	}
}
