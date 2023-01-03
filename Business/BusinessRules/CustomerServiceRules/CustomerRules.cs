namespace Business.BusinessRules.CustomerServiceRules
{
    public class CustomerRules
    {
        public static bool IsUnusualName(string name)
        {
            string customerName = name.ToLower();

            Dictionary<char, int> characterCounts = new Dictionary<char, int>();
            foreach (char c in customerName)
            {
                if (!characterCounts.ContainsKey(c))
                {
                    characterCounts[c] = 0;
                }
                characterCounts[c]++;
            }

            bool isUncommon = false;
            foreach (var item in characterCounts)
            {
                if (item.Key == 'a' || item.Key == 'e' || item.Key == 'ı' || item.Key == 'i' || item.Key == 'o' || item.Key == 'ö' || item.Key == 'u' || item.Key == 'ü')
                {
                    if (item.Value >= 3)
                    {
                        isUncommon = true;
                        break;
                    }
                }
            }

            return isUncommon;
        }
    }
}