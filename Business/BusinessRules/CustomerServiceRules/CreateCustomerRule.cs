namespace Business.BusinessRules.CustomerServiceRules
{
    public class CreateCustomerRule
    {
        public static bool IsUnusualName(string name)
        {
            char[] vovels = new char[] { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            char[] nameArray = name.ToArray();


            int counter = 0;

            for (int i = 0; i < nameArray.Length; i++)
            {
                bool isContain = nameArray.Contains(vovels[i]);

                //
                // 

            }

            return true;
        }
    }
}