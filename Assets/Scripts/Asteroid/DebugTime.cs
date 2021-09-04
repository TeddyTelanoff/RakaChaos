using UnityEditor;

using UnityEngine;

public partial class DebugTime
{
	public void SpawnAsteroid()
	{
		Spawner.instance.Asteroid();
	}
}