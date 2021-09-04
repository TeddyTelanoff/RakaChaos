using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Asteroid: MonoBehaviour
{
	public Rigidbody2D rb;
	public float baseSpeed;

	public float speed => baseSpeed * Time.deltaTime;

	public void Start()
	{
		Spawn();
	}
}
