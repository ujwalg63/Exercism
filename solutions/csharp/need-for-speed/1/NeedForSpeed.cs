class RemoteControlCar
{
    private int distanceDriven;
    public int Speed;
    public int BatteryDrain;
    public int BatteryPercentage = 100;
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain)
    {
        Speed = speed;
        BatteryDrain = batteryDrain;
    }
    public bool BatteryDrained()
    {
        if(BatteryPercentage < BatteryDrain)
        {
            return true;
        }
        return false;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if(!BatteryDrained())
        {
            distanceDriven += Speed;
            BatteryPercentage = BatteryPercentage - BatteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    public int Distance;
    public RaceTrack(int distance)
    {
        Distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();

            if (car.DistanceDriven() >= Distance)
            {
                return true;
            }
        }

        return false;
    }
}
