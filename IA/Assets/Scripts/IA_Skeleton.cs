using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Skeleton : MonoBehaviour {

	public enum States {Idle, Perseguir, Atacar, Volver};
	public States miestado = States.Idle;
	public GameObject Player;

	public Transform target;
	public float speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
