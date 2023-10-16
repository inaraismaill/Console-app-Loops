// See https://aka.ms/new-console-template for more information
//Arrayde elementin sayini gosterin. 
//Example:
//int[] arr = { 2, 3, 6, 6 }
//2-> 1 dene
//3-> 1 dene
//6 -> 2 dene

//int[] arr = { 6, 6,0,6,8,-1,1,1};
//foreach (int component in arr)
//{
//    int count = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] == component)
//        {
//            //Console.WriteLine(arr[i]);
//            count++;
//            arr[i] = int.MinValue;
//        }
//    }
//    if (count > 0 && component!=int.MinValue)
//    {
//        Console.WriteLine($"{component} -> {count} dene");
//    }
//}



//App acilanda userden arrayin olcusunu daxil etmesini isteyin. Daha sonra element elave edib etmek istemediyini sorushun.Element elave etmek isteyirse etsin(Yes, yes, Y, y), istemirse proqrami dayandirin. Arrayin olcusunden cox olmayaraq, her defe element elave etmek istediyini sorushun. 

//Console.Write("arrayin uzunlugunu daxil edin: ");
//int arrlen = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[arrlen];
//for (int i = 0; i < arrlen; i++)
//{
//    Console.Write("element daxil etmel isteyirsiz? 'y or yes or Y or Yes': ");
//    string answer= Console.ReadLine();
//    if (answer =="y" || answer=="yes" || answer=="Y" || answer == "Yes")
//    {
//        Console.Write("elementi daxil edin: ");
//        string element = Console.ReadLine();
//    }
//    else
//    {
//        break;
//    }
//}