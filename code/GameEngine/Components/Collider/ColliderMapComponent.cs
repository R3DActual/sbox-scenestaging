﻿using Sandbox;
using Sandbox.Diagnostics;
using System.Collections.Generic;

[Title( "Collider - Map" )]
[Category( "Physics" )]
[Icon( "panorama_fish_eye", "red", "white" )]
public class ColliderMapComponent : Collider
{
	public ColliderMapComponent()
	{

	}

	protected override IEnumerable<PhysicsShape> CreatePhysicsShapes( PhysicsBody targetBody )
	{
		yield break;
	}

	internal void SetBody( PhysicsBody body )
	{
		keyframeBody = body;
	}

	protected override void OnEnabled()
	{
		// nothing
	}

	protected override void OnDisabled()
	{
		// nothing
	}
}
