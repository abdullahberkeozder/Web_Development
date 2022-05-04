using System;

class User
{
    private
        Club SupportedClub;
        float monthlySupport;
        DateTime StartDate;
        DateTime EndDate;
        float totalDebt;
        string Name;
        int age;

    public Club SupportedClub1 { get => SupportedClub; set => SupportedClub = value; }
    public float MonthlySupport { get => monthlySupport; set => monthlySupport = value; }
    public DateTime StartDate1 { get => StartDate; set => StartDate = value; }
    public DateTime EndDate1 { get => EndDate; set => EndDate = value; }
    public float TotalDebt { get => totalDebt; set => totalDebt = value; }
    public string Name1 { get => Name; set => Name = value; }
    public int Age { get => age; set => age = value; }
}
