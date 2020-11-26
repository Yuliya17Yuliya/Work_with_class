using System;

namespace LW_12_13
{
    class Patient
    {
        public string Family;
        public string Name;
        public string Otchestvo;
        public string Addres;
        public int Card;
        public string Diagnosis;
        public void GetInfo()
        {
            Console.WriteLine($"Фамилия: {Family}, Имя: {Name}, Отчество: {Otchestvo}, Адрес: {Addres}, Карта: {Card}, Диагноз: {Diagnosis}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Разработать класс для объекта Patient: Фамилия, Имя, Отчество, Адрес, Номер медицинской карты, Диагноз.
            //Создать массив объектов.Вывести:
            // а) список пациентов, имеющих данный диагноз;
            // б) список пациентов, номер медицинской карты которых находится в заданном интервале.

            Patient[] Patient = new Patient[3]; //Создание массива объектов:

            for (int i=0; i<3; i++) // Ввод с экрана
            {
                Patient[i].Family = Console.ReadLine();
                Patient[i].Name = Console.ReadLine();
                Patient[i].Otchestvo = Console.ReadLine();
                Patient[i].Addres = Console.ReadLine();
                Patient[i].Card = Convert.ToInt32(Console.ReadLine());
                Patient[i].Diagnosis = Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)
                Patient[i].GetInfo();

            // а) список пациентов, имеющих данный диагноз;

            for (int i = 0; i < 3; i++)
                if (Patient[i].Diagnosis == "Skoleos")
                    Patient[i].GetInfo();

            // б) список пациентов, номер медицинской карты которых находится в заданном интервале.

            for (int i = 0; i < 3; i++)
                if (Patient[i].Card > 10 && Patient[i].Card < 20)
                    Patient[i].GetInfo();

            Console.ReadKey();
        }
    }
}
