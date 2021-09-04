using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Spawner : MonoBehaviour
{
	public static Spawner instance;

	public void Awake() =>
		instance = this;
}
