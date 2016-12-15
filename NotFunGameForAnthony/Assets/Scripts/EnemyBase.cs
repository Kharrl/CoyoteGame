using UnityEngine;
using System.Collections;
using System;

public class EnemyBase : MonoBehaviour {
	public static Action <GameObject> AddMe;
	public NavMeshAgent Enemy;
	private Rigidbody Enemyrb;
	public float EnemySpeed;
	public int EnemyHealth;
	public int EnemyMaxHealth =100;
	public Transform Player;
	public Transform Shrine;
	public Transform Relic;
	public bool InRange=false;
	private float Power;
	// Use this for initialization
	void Start () {
		AddMe (this.gameObject);
		Enemy = GetComponent<NavMeshAgent> ();
		Enemyrb = GetComponent<Rigidbody> ();
		EnemyHealth = EnemyMaxHealth;
		Enemy.speed = EnemySpeed;
		WeaponBase.FireWep += DamageHandler;
	}
	void OnTriggerEnter()
	{
		InRange = true;
	}
	void OnTriggerExit()
	{
		InRange = false;
	}
	void DamageHandler (int D)
	{
		EnemyHealth -= D;
	}
	public void KnockBackHandler(float _K)
	{
		Power=_K;
		StartCoroutine (knockedback ());
	}
	IEnumerator knockedback ()
	{
		Enemyrb.AddForce (Vector3.back * Power);
		yield return new WaitForSeconds (0.1f);
		Enemyrb.AddForce (Vector3.forward * Power);
	}
}
