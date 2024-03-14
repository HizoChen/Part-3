using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    protected override void Attack()
    {
        if (transform.localScale.x > 0)
            {
                transform.Translate(Vector3.left);
            }
       else if (transform.localScale.x < 0)
            {
            transform.Translate(Vector3.right);
        }
        destination = transform.position;
        base.Attack();
        base.Dash();
        Instantiate(daggerPrefab, spawnPoint.position, spawnPoint.rotation);
        Instantiate(daggerPrefab, spawnPoint2.position, spawnPoint2.rotation);
        
    }
    public override ChestType Canopen()
    {
        return ChestType.Thief;
    }

}
