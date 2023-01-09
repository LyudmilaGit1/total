// Написать программу которая из имеющегося массива строк формирует массив из строк, 
//длинна которых меньше либо равна 3 символам.

        string[] M;
            Console.WriteLine("Введите массив строк через пробел");
            string words = Console.ReadLine();
            M = words.Split(' ');
            
            
            var Len= new string[M.Length];
            var Index = 0;
            foreach (var temp in M )
            {
                if (temp.Length <= 3)
                {
                    Len[Index]= temp ;
                    Index++;
                    Console.Write($"'{temp}',");
                }
                
            }
            
           