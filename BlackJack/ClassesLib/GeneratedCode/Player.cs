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

public class Player
{
	public virtual int bet
	{
		get;
		set;
	}

	public virtual string hit
	{
		get;
		set;
	}

	public virtual string stay
	{
		get;
		set;
	}

	public virtual int MyBet()
	{
		throw new System.NotImplementedException();
	}

	public virtual void RequestAction(object Hand, object Dealer visable hand)
	{
		throw new System.NotImplementedException();
	}

}

