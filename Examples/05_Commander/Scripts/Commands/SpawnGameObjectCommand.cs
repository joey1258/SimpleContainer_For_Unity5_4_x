﻿using UnityEngine;
using uMVVMCS.DIContainer;

namespace uMVVMCS.Examples.Commander
{
	public class SpawnGameObjectCommand : Command
    {
		[Inject]
		public IInjectionContainer container;

		public override void Execute(params object[] parameters)
        {
			var prefab = container.Resolve<Transform>();
			dispatcher.Dispatch<RotateGameObjectCommand>(prefab);
		}
	}
}