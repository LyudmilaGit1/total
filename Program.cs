// Написать программу которая из имеющегося массива строк формирует массив из строк, 
//длинна которых меньше либо равна 3 символам.

 string[] M;
            Console.WriteLine("Введите массив строк через пробел");
            string words = Console.ReadLine();
            M = words.Split(' ');
            
              
            var Long= new string[M .Length];
            var Count = 0;
            foreach (var temp in M )
            {
                if (temp.Length <= 3)
                {
                    Long[Count] = temp;
                    Count++;
                    Console.Write($"'{temp}',"); 
                }
               
            }
            
            // Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
            //Console.ReadKey(true);