using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental.day09
{
    internal class CarImpl : ICar
    {
        public void DisplayCar()
        {
            Console.WriteLine($"test");
        }

        public Car? FindCarByNomor(List<Car> listCar, string nomor)
        {
            return listCar.Find(e => e.NoPolisi.Equals(nomor));
            throw new NotImplementedException();
        }

        public List<Car> FindCarByType(List<Car> listCar, EnumCar carType)
        {
            return listCar.FindAll(e => e.Type.Equals(carType.ToString()));
            throw new NotImplementedException();
        }

        public List<Car> InitListCar(Car[] cars)
        {
            List<Car> listCar = new List<Car>();
            listCar.AddRange(cars);
            return listCar;

            throw new NotImplementedException();
        }

        public decimal TotalPendapatan(List<Car> listCar, EnumCar carType)
        {
            decimal totalPendapatan = 0M;

            switch (carType)
            {
                case EnumCar.ALL_CAR:
                    totalPendapatan = listCar.Sum(e => e.TotalPendapatan);
                    break;
                case EnumCar.ANGKOT:
                case EnumCar.SUV:
                case EnumCar.TAXI:
                case EnumCar.HELICOPTER:
                case EnumCar.CESSNA:
                case EnumCar.BOAT:
                    totalPendapatan = listCar.Where(e => e.Type.Equals(carType.ToString())).Sum(item => item.TotalPendapatan);  
                    break;
                default:
                    break;
            }

            return totalPendapatan;

            throw new NotImplementedException();
        }
    }
}
