using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Spawner
{
	public Transform asteroidParent;
	public GameObject asteroidPrefab;

	public void Asteroid() =>
		Instantiate(asteroidPrefab, asteroidParent);
}

public partial class Asteroid
{
	public void Spawn()
	{
		var dir = Random.insideUnitCircle.normalized;
		transform.position = -dir * Camera.main.orthographicSize * 2;
		rb.AddForce(dir * speed);
	}
}
