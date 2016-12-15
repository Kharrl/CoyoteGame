using UnityEngine;
using System.Collections;

public interface IWeapon {
	void Awake();
	void Special ();

}
public interface IPowerup{
	void OnTriggerEnter ();
	Rigidbody PowerUp{set;
}
}
