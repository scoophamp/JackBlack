﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BetHandler
{
    Player player = new Player();
    public int MyAmount // property of the total amount
	{
		get;
		set;
	}

    public List<int> PlayersBet = new List<int>(); //The list of players bets

    public void playersbet()
    {
        PlayersBet.Add(0); //The valuee represents players
        PlayersBet.Add(1);
    }

	public int SetPlayerBet() //sets the players bet
	{
        player.bet = player.bet;
        return player.bet;
	}

	public int WinAmount() // Sets the winning amount to the method
	{
        int winningBet = player.bet * 2;
        MyAmount = MyAmount + winningBet;
        return MyAmount;
	}

	public int CheckAmount() //Checks the current value of MyAmount
	{
        MyAmount = MyAmount;
        return MyAmount;
	}

	public int LoseAmount() //Sets the loose to the method
	{
        
        MyAmount = player.bet - MyAmount;
        return MyAmount;
	}

}
