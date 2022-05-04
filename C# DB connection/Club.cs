using System;
class Club
{
    private
        int id;
        string name;
        int numberOfSupporters = 0;

        public Club(int id, string name, int supporters)
        {
            this.Id = id;
            this.name = name;
            numberOfSupporters = supporters;
        }
        public Club() {
        id = -1;
        name = "Null";
        numberOfSupporters = 0;
        }
        public void addSupporters()
        {
            numberOfSupporters++;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int NumberOfSupporters { get => numberOfSupporters; set => numberOfSupporters = value; }
}
