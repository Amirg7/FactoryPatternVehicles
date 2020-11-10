using System;
namespace FactoryPatternVehicles
{
    public static class VehicleFactory 
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
            if (wheelCount == 4) 
            {
                switch (wheelCount)
                {
                    case 2:
                        return new Motorcycle();
                    case 3:
                        return new ThreeWheeler();
                    case 4:
                        return new Car();
                    
                        
                }


            }
            return new Car();
        }

        
    }
}
