namespace MaxSum
{
    public class Selector
    {
        public static string SelectPath(string[] args)
        {
            if (args.Length > 0)
                return args[0];

            return Input.UserPath();
        }
    }
}
