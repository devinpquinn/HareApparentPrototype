﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Character
{
    [Header("Voting Info")]
    private int myVote; // id of current vote target
    private int voteStrength; // point strength of current vote deal

    private void Start()
    {
        RoundReset();
    }

    public void RoundReset() // reset for next round of play
    {
        voteStrength = -1;
    }

    public void CompareVote(int proposer, int target, int targetID) // function for comparing various votes
    {
        int str = proposer - target;
        if(str > voteStrength)
        {
            myVote = targetID;
            voteStrength = str;
            return;
        }
        if(str == voteStrength)
        {
            int tiebreaker = Random.Range(0, 2);
            if(tiebreaker == 0)
            {
                myVote = targetID;
                voteStrength = str;
                return;
            }
        }
    }

}
