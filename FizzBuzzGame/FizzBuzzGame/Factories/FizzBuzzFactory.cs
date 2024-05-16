﻿namespace FizzBuzzGame;

public class FizzBuzzFactory : INumberFactory
{
    public int DivisableBy => 15;

    public string GetFizzBuzzValue(int input)
    {
        return "FizzBuzz";
    }
}