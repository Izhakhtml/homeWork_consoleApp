using HomeWorkConsoleApp;
// Generics mession \\
// exe 1
// one way 
//Square<int> Intger = new Square<int>(4);
//Square<double> Double = new Square<double>(1.22);
//Square<Byte> Byte = new Square<Byte>(255);
//Square<long> Float = new Square<long>(9999999999999999);
// exe 1-2-3
//Square<int> Intger = new Square<int>(1,2,3,4,"black");
//Square<double> Double = new Square<double>(1.1, 2.2, 3.3, 4.4, "green");

// Lists mession \\
// exe 1
//static void GetLastName(string fm1, string fm2, string fm3, string fm4, string fm5)
//{
//    List<string> lastNameList = new List<string>();
//    lastNameList.Add(fm1);
//    lastNameList.Add(fm2);
//    lastNameList.Add(fm3);
//    lastNameList.Add(fm4);
//    lastNameList.Add(fm5);
//    lastNameList.Sort((a,b) => a.Length - b.Length);
//    int i = 0;
//    while (i < lastNameList.Count)
//    {
//       Console.WriteLine(lastNameList[i]);
//        i++;
//    }
//}
//GetLastName("iirsdfsdr","zzrr","ewfss","hh","rr");
//exe 2
//User user1 = new User("izzrrrrr", "lijalem", 12);
//User user2 = new User("ds", "lijalem", 12);
//User user3 = new User("izasz", "lijalem", 12);
//User user4 = new User("isdzz", "lijalem", 12);
//User user5 = new User("izasaz", "lijalem", 12);
//User listUser = new User();
//listUser.listString = new List<string>();
//listUser.listString.Add(user1.firstName);
//listUser.listString.Add(user2.firstName);
//listUser.listString.Add(user3.firstName);
//listUser.listString.Add(user4.firstName);
//listUser.listString.Add(user5.firstName);
//listUser.listString.Sort((a, b) => a.Length - b.Length);
//int i = 0;
//while (i < listUser.listString.Count)
//{
//    Console.WriteLine(listUser.listString[i]);
//    i++;
//}
// Bank mession \\
// exe 1-2-3-4
//Bank client1 = new Bank("green", 3.4, 80000);
//Bank client2 = new Bank("black", 5.4, 60000);
//Bank client3 = new Bank("pink", 4.4, 50000);
//Bank[] arr = new Bank[]{client1,client2,client3};
//Array.Sort(arr);
//int i  = 0;
//while (i < arr.Length)
//{
//    arr[i].Print();
//    i++;
//}
// exe 5
List<Bank> list = new List<Bank>();
list.Add(new Bank("green", 3.4, 80000));
//Console.WriteLine(list[0].value);
static void consoleBank()
{
Console.WriteLine("DEPOSIT MONEY TAP 1");
Console.WriteLine("CASH WITHRAWAL TAP 2"); 
}
static void userBank() 
{
    int input;
            List<Bank> list = new List<Bank>();
            list.Add(new Bank("green", 3.4, 8000));
    consoleBank();
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            try
            {
              Console.WriteLine("DEPOSIT MONEY:");
              list[0].value += input = int.Parse(Console.ReadLine());
              Console.WriteLine($"Desposit amount:{input}");
              Console.WriteLine($"SHOW BALANCE :{list[0].value}");
            }
            catch (FormatException)
            {
                Console.WriteLine("enter number please");
                userBank();
            }
            break;
        case 2:
            try
            {
                Console.WriteLine("CASH WITHRAWAL:");
                list[0].value -= input = int.Parse(Console.ReadLine());
                Console.WriteLine($"WITHRAWAL amount:{input}");
                Console.WriteLine($"SHOW BALANCE :{list[0].value}");
            }
            catch (FormatException)
            {
                Console.WriteLine("enter number please");
                userBank();
            }
            break;

        default:
    
            break;
    }
}
userBank();  
//Bank client1 = new Bank();
            //double gg = 0;
            //int i = 0;
            //List<double> list = new List<double>();
            //client1.value = int.Parse(Console.ReadLine());
            //while(client1.value!= 0) {
            //client1.value = int.Parse(Console.ReadLine());
            //list.Add(client1.value);
            //}
            //while (i < list.Count) { gg += list[i]; i++; }
            //consoleBank();
            //Console.WriteLine($"TOTAL:{gg}");
            //int value = int.Parse(Console.ReadLine());