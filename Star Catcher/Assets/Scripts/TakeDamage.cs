using UnityEngine;
using System.Collections;

public class TakeDamage : MonoBehaviour {

	public int Damage = 25;


	public void OnTriggerEnter()
	{
		StaticVar.StarPower -= Damage;
		print ("Star Power = " + StaticVar.StarPower);
		if (StaticVar.StarPower <= 0) {
			print ("you dead");
		}
	}
}
