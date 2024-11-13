
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Target
{
    
    protected int damage;
    // Start is called before the first frame update
    protected override void Die()
    {
        Debug.Log("Golem has been defeated!");
        Destroy(gameObject);
        //base.Awake();
        //health = 120;
        //damage = 5;
        //GameManager.Instance.score += 2;

    }

   

    public override void TakeDamage(float amount)
    {
        float reducedAmount = amount * 2f;
        base.TakeDamage(reducedAmount);
    }
}
