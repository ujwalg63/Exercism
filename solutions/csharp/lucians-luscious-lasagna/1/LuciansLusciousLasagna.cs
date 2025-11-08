class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        int expectedTime  = 40;
        return expectedTime;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int howLongInsideMins)
    {
        Lasagna lasagna = new Lasagna();
        int expectedtime  = lasagna.ExpectedMinutesInOven();
        int RemainingMinutes = expectedtime - howLongInsideMins;
        return RemainingMinutes;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numOfLayers)
    {
        int prepTimeInMinutes = numOfLayers * 2;
        return prepTimeInMinutes;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numOfLayers, int howLongInsideMins)
    {
        int preptime = numOfLayers * 2;
        return preptime + howLongInsideMins;
    }
}
