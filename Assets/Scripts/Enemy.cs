using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Participant
{
    private string _participantName;
    public override string ParticipantName
    {
        get { return _participantName; }
        set
        {
            if (value?.Length > 20)
                _participantName = value;
        }
    }
    public override float Health { get; set; }
    public override float Armour { get; set; }

    public override void Attack()
    {
    }

    public override void TakeDamage()
    {
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
