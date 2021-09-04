using UnityEditor;

using UnityEngine;

public partial class DebugTime: EditorWindow
{
	[MenuItem("Window/Debug RakaChaos")]
	public static void ShowWindow() =>
		GetWindow<DebugTime>("RakaChaos Debug");

	public void OnGUI()
	{
		if (GUILayout.Button("Spawn Asteroid"))
			SpawnAsteroid();
	}
}