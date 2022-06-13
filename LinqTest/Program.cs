namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OurList> inputList = new List<OurList>();
            int listSize = 2; //List size
            //list input
            for(int i = 0; i < listSize; i++)
            {
                OurList our = new OurList();
                our.Firm = Console.ReadLine();
                our.EmployeeCount = int.Parse(Console.ReadLine());
                our.EmployeeWithDegree = int.Parse(Console.ReadLine());
                inputList.Add(our);
            }
            List<OurList> newList = new List<OurList>();
            /*LinQ query
            Sort our list and fill output list with sorted data
            */
            newList = inputList.OrderBy(q => (q.EmployeeWithDegree/q.EmployeeCount)).ToList();
            // вывод ответа
            foreach(OurList o in newList)
            {
                Console.WriteLine(o);
            }
            
        }
    }
    //requerd class
    public class OurList
    {
        public string Firm { get; set; }
        public int EmployeeCount { get; set; }
        public int EmployeeWithDegree { get; set; }
        public override string ToString()
        {
            string output = "Фирма: " + Firm + " Кол-во сотрудников: " + EmployeeCount + " Сотрудники с высшим обр-нием: " + EmployeeWithDegree;
            return output;
        }
    }
}
