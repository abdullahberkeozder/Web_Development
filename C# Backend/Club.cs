using System;


class Club
{
    private
        int id;
    string Name;
    int numberOfSupporters;

    public Club(int id, string name, int numberOfSupporters)
    {
        this.Id = id;
        Name1 = name;
        this.NumberOfSupporters = numberOfSupporters;
    }

    public int Id { get => id; set => id = value; }
    public string Name1 { get => Name; set => Name = value; }
    public int NumberOfSupporters { get => numberOfSupporters; set => numberOfSupporters = value; }
}
