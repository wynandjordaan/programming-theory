using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Participant : MonoBehaviour
{
    public abstract string ParticipantName { get; set; }
    public abstract float Health { get; set; }
    public abstract float Armour { get; set; }

    public abstract void TakeDamage();
    public abstract void Attack();
}
