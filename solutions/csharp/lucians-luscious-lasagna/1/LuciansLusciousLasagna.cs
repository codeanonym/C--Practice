class Lasagna
{
    int expectedMinutesInOven = 40;

    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return expectedMinutesInOven;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesInOven){
        var remainingMinutesInOven = expectedMinutesInOven - minutesInOven;
        return remainingMinutesInOven;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layersOfLasagna){
        return (layersOfLasagna * 2);
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layersOfLasagna, int minutesInOven){
        return minutesInOven + (layersOfLasagna * 2);
    }
    
}
