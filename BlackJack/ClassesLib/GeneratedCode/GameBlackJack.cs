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

public class GameBlackJack
{
    Amount amount = new Amount();
    Board board = new Board();
    Deck deck = new Deck();
    Hand hand = new Hand();
    Rules rules = new Rules();
    Player player = new Player();
    Dealer dealer = new Dealer();
    Card card = new Card();


	public virtual void StartGame()
	{
		throw new System.NotImplementedException();
	}
    public void CurrentAmount()
    {
        amount.MyAmount = 100;
    }
    

}

