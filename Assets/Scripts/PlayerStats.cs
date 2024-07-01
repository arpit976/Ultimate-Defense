using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

	public static int Money;
	public int startingMoney = 400;

	public static int Lives;
	public int startingLives = 20;

    public static int Turrents;
    public int turrents = 7;

    public static int Rounds;

	void Start ()
	{
		Money = startingMoney;
		Lives = startingLives;
		Turrents = turrents;

        Rounds = 0;
	}

}
