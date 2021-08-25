using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Spawner
{
	public Transform asteroidParent;
	public GameObject asteroidPrefab;

	public void Start()
	{
		var obj = Instantiate(asteroidPrefab, asteroidParent);
		obj.GetComponent<Asteroid>().MakeMesh();
	}
}

public partial class Asteroid
{
	public MeshFilter meshFilter;
	private Mesh mesh;

	public void MakeMesh()
	{
		int numVerts = Random.Range(6, 12);
		var verts = new Vector3[numVerts];

		int numIndices = numVerts * 3;
		int[] indices = new int[numIndices];

		verts[0] = Random.insideUnitCircle;
		for (int i = 1; i < numVerts; i++)
		{
			int prevIndex = i - 1;
			ref Vector3 prevVert = ref verts[prevIndex];
			verts[i] = prevVert + (Vector3) Random.insideUnitCircle;
		}

		mesh = new Mesh();
		mesh.vertices = verts;
		mesh.RecalculateNormals();
		meshFilter.mesh = mesh;
	}
}
