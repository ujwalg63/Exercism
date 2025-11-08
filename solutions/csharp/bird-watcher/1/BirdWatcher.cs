class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] {0, 2, 5, 3, 7, 8, 4};
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length-1]++;
    }

    public bool HasDayWithoutBirds()
    {
         foreach(int i in birdsPerDay)
         {
             if(i==0)
             {
                 return true;
             }
         }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        try 
        {
            int count = 0;
            for(int i=0; i<numberOfDays; i++)
            {
                count = count + birdsPerDay[i];
            }
            return count;
        }
        catch{
            throw new NotImplementedException("Enter a valid number of days.");
        }
        
    }

    public int BusyDays()
    {
        int count = 0;
        foreach(int i in birdsPerDay)
        {
            if(i >=5)
            {
                count = count + 1;
            }
        }
        return count;
    }
}
