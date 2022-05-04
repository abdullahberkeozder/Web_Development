List<User>users = new List<User>();
User user = new User();


List<Club>clubs= new List<Club>();
Club Manu = new Club();
Manu.Id = 1;
Manu.Name1 = "Manchester United FC";
Manu.NumberOfSupporters = 0;
clubs.Add(Manu);

Club Chelsea = new Club();
Chelsea.Id = 2;
Chelsea.Name1 = "Chelsea FC";
Chelsea.NumberOfSupporters = 0;
clubs.Add(Chelsea);

Club Leeds = new Club();
Leeds.Id = 3;
Leeds.Name1 = "Leeds United FC";
Leeds.NumberOfSupporters = 0;
clubs.Add(Leeds);

Club Arsenal = new Club();
Arsenal.Id = 4;
Arsenal.Name1 = "Arsenal FC";
Arsenal.NumberOfSupporters = 0;
clubs.Add(Arsenal);


Console.WriteLine("Enter Number Of Support To ADD: ");
int supporters = Int32.Parse(Console.ReadLine());

while(supporters > 0)
    Console.WriteLine("Write Your Full Name");
    user.Name1 = Console.ReadLine();
    user.Age = Int32.Parse(Console.ReadLine());
    user.MonthlySupport = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Choose Your Favorite Club Among the Clubs With The ID");
    Console.WriteLine("CLUB: 1" );
    Console.WriteLine("CLUB: 2, Chelsea FC");
    Console.WriteLine("CLUB: 3, Leeds United FC");
    Console.WriteLine("CLUB: 4, Arsenal FC");
    user.SupportedClub1.Id= Int32.Parse(Console.ReadLine());

    Console.WriteLine("Write Enter Date(E.G. 10/12/1987):");
    user.StartDate1 = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Write End Date(E.G. 10/12/1987):");
    user.EndDate1 = DateTime.Parse(Console.ReadLine());
    
    users.Add(user);

    supporters--;


