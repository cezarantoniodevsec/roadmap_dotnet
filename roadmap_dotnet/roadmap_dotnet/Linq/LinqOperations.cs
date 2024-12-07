using roadmap_dotnet.Linq.Models;

namespace roadmap_dotnet.Linq
{
    public static class LinqOperations
    {
        //	Aggregate
        public static string makeAggregate()
        {
            string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };

            string longestName =
                fruits.Aggregate("banana",
                                (longest, next) =>
                                    next.Length > longest.Length ? next : longest,
                                fruit => fruit.ToUpper());

            return longestName;
        }
        //	All
        public static bool makeALL()
        {
            Pet[] pets = { new Pet { Name="Barley", Age=10 },
                   new Pet { Name="Boots", Age=4 },
                   new Pet { Name="Whiskers", Age=6 } };

            return pets.All(pet => pet.Name.StartsWith("B"));
        }

        //	Any
        public static string makeAny()
        {
            List<Person> people = new List<Person>
            {
                new Person
                {
                    LastName = "Haas",
                    Pets = new Pet[]
                    {
                        new Pet { Name="Barley", Age=10 },
                        new Pet { Name="Boots", Age=14 },
                        new Pet { Name="Whiskers", Age=6 }
                    }
                },
                new Person
                {
                    LastName = "Fakhouri",
                    Pets = new Pet[]
                    {
                       new Pet
                       {
                         Name = "Snowball", Age = 1
                       }
                    }
                },
                new Person
                {
                    LastName = "Antebi",
                    Pets = new Pet[]
                    { }
                },
                new Person
                {
                    LastName = "Philips",
                    Pets = new Pet[]
                    {
                        new Pet { Name = "Sweetie", Age = 2},
                        new Pet { Name = "Rover", Age = 13}
                    }
                }
            };

            IEnumerable<string> names = from person in people
                                        where person.Pets.Any()
                                        select person.LastName;

            return names.FirstOrDefault();
        }

        // Apppend 
        public static List<int> makeAppend()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            numbers = numbers.Append(5).ToList();
            return numbers;
        }

        // AsEnumerable
        public static IEnumerable<string> makeEnumerable(bool overide)
        {
            Clump<string> conjuntoFrutas = new Clump<string> { "apple", "passionfruit", "banana",
                "mango", "orange", "blueberry", "grape", "strawberry" };

            IEnumerable<string> frutasComLetraSemOvveride =
                conjuntoFrutas.Where(fruit => fruit.Contains("o"));

            IEnumerable<string> frutasComLetraComvveride =
                conjuntoFrutas.AsEnumerable().Where(fruit => fruit.Contains("o"));

            return overide ? frutasComLetraSemOvveride.ToList() : frutasComLetraComvveride.ToList();
        }

        //	Average
        public static double? makeAverage()
        {
            long?[] longs = { null, 10007L, 37L, 399846234235L };

            double? average = longs.Average();

            return average;
        }

        //	Cast
        public static List<string> makeCast()
        {
            System.Collections.ArrayList fruits = new System.Collections.ArrayList();
            fruits.Add("mango");
            fruits.Add("apple");
            fruits.Add("lemon");

            IEnumerable<string> query =
                fruits.Cast<string>().OrderBy(fruit => fruit).Select(fruit => fruit);

            return query.ToList();
        }

        // Chunk
        public static IEnumerable<int> makeChunk(int element)
        {
            List<int> numeros = new();
            int contador = 0;

            while (contador < 9)
            {
                numeros.Add(contador);
                contador++;
            }

            var fatias = numeros.Chunk(3);

            return fatias.ElementAt(element);
        }

        //	Concat
        public static IEnumerable<string> makeConcat()
        {
            Pet[] cats =
            {
                new Pet { Name="Barley", Age=8 },
                new Pet { Name="Boots", Age=4  },
                   new Pet { Name="Whiskers", Age=1 }
            };

            Pet[] dogs =
            {
                new Pet { Name="Bounder", Age=3 },
                new Pet { Name="Snoopy", Age=14 },
                new Pet { Name="Fido", Age=9 }
            };

            IEnumerable<string> petsMisturados =
                cats.Select(cat => cat.Name).
                    Concat(dogs.Select(dog => dog.Name));

            return petsMisturados.ToList();
        }

        //	Distinct
        public static List<string> makeDistinct()
        {
            Product[] products =
            {
                new Product { Name = "apple", Code = 9 },
                new Product { Name = "orange", Code = 4 },
                new Product { Name = "apple", Code = 9 },
                new Product { Name = "lemon", Code = 12 }
            };

            IEnumerable<Product> noduplicates =
                products.Distinct(new ProductComparer());

            var nomeProdutos = new List<string>();
            foreach (var item in noduplicates.ToList())
            {
                nomeProdutos.Add($"{item.Name}-{item.Code}");
            }

            return nomeProdutos;
        }

        //	Except
        public static IEnumerable<double> makeExcept()
        {
            double[] numbers1 = { 2.0, 2.0, 2.1, 2.2, 2.3, 2.3, 2.4, 2.5 };
            double[] numbers2 = { 2.2 };

            IEnumerable<double> onlyInFirstSet =
                numbers1.Except(numbers2);

            return onlyInFirstSet.ToList();
        }

        //	GroupJoin
        public static List<string> makeGroupJoin()
        {
            Person magnus = new Person { Name = "Hedlund, Magnus" };
            Person terry = new Person { Name = "Adams, Terry" };
            Person charlotte = new Person { Name = "Weiss, Charlotte" };

            Pet barley = new Pet { Name = "Barley", Owner = terry };
            Pet boots = new Pet { Name = "Boots", Owner = terry };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

            List<Person> people = new List<Person> { magnus, terry, charlotte };
            List<Pet> pets = new List<Pet> { barley, boots, whiskers, daisy };

            var query =
                people.GroupJoin(pets,
                                 person => person,
                                 pet => pet.Owner,
                                 (person, petCollection) =>
                                     new
                                     {
                                         OwnerName = person.Name,
                                         Pets = petCollection.Select(pet => pet.Name)
                                     });

            var nomesXProprietarios = new List<string>();
            var combinacao = string.Empty;

            foreach (var obj in query)
            {
                combinacao = obj.OwnerName;

                foreach (string pet in obj.Pets)
                {
                    combinacao += $"x{pet}";
                }

                nomesXProprietarios.Add(combinacao);
            }
            return nomesXProprietarios;
        }

        //	Intersect
        public static string makeIntersect()
        {
            ProductA[] store1 =
            {
                new ProductA
                {
                    Name = "apple", Code = 9
                },
                new ProductA
                {
                    Name = "orange", Code = 4
                }
            };

            ProductA[] store2 =
            {
                new ProductA
                {
                    Name = "apple", Code = 9
                },
                new ProductA
                {
                    Name = "lemon", Code = 12
                }
            };

            IEnumerable<ProductA> duplicates = store1.Intersect(store2);

            var interceptedProduct = duplicates.FirstOrDefault();

            return $"{interceptedProduct.Name} - {interceptedProduct.Code}";
        }

        //	SelectMany
        //	ToLookup
        //	SequenceEqual        

        // Os seguintes métodos são auto-explicativos 
        //	Contains
        //	Count        
        //	DefaultIfEmpty
        //	ElementAt
        //	ElementAtOrDefault
        //	Empty
        //	First
        //	FirstOrDefault
        //	GroupBy
        //	Join
        //	Last
        //	LastOrDefault
        //	LongCount
        //	Max
        //	Min
        //	OfType
        //	OrderBy
        //	OrderByDescending
        //	Range
        //	SkipWhile
        //	TakeWhile
        //	ThenBy
        //	ThenByDescending
        //	ToDictionary
        //	Union
        //	Select
        //	Take
        //	Skip
        //	ToArray
        //	Sum
        //	Single
        //	SingleOrDefault
        //	ToList 
        //	Where

    }
}
