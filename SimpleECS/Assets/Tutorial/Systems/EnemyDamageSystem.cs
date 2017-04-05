﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[AddComponentMenu("EntitySystem/EnemyDamageSystem")]
public class EnemyDamageSystem : EntitySystem, UpdateSystem
{
	public override void InitializeSystem ()
	{
		AddEntityEvent<BulletCollisionEvent>(OnBulletCollisionEvent);
	}

	void OnBulletCollisionEvent(Entity sender, Entity reciever, BulletCollisionEvent args)
	{
		if (reciever.Has<EnemyComponent>())
		{
			var spin = reciever.GetOrAdd<SpinComponent>();
			spin.timeSpinning = 0;
			spin.enabled = true;
		}
	}

}

public struct BulletCollisionEvent{}
