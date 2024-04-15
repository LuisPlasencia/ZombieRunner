using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] float hitPoints = 100f;

    public void TakeDamage(float damage)
    {
        this.hitPoints -= damage;
        if(this.hitPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }

}
