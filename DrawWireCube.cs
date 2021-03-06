﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawWireCube : MonoBehaviour {

	public Vector3 scale = Vector3.one;
	public Vector3 offSet;

	private void OnDrawGizmosSelected() {
		Gizmos.color = Color.blue;
		Gizmos.matrix = Matrix4x4.TRS(transform.position,transform.rotation,scale);
		Gizmos.DrawWireCube(Vector3.zero+offSet,transform.lossyScale);
	}
}
