using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DanilovAS.Sprint3.Task3.V24.Lib
{
    public class DataService : ISprint3Task3V24
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            string str = value;
            foreach(char c in str)
            {
                if (c == replaceable)
                {
                    str = str.Replace(replaceable, replacement);
                }
            }
            return str;
        }
    }
}
