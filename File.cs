namespace _20JulyIDisposableEx1
{
    public class File
    {
        string name;
        public string Name { get { return name; } set { name = value; } }
        public File(string name)
        {
            this.name = name;
        }
    }
}
