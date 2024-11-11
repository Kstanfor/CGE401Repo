using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{

    protected int damage;
    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();
        health = 120;
        //damage = 5;
        GameManager.instance.score += 2;
    }

    protected override void Attack()
    {
        Debug.Log("Golem Attacks!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("You Took " + amount + " points of damage");
    }
}
