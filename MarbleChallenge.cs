using System;

namespace ScubeMarbleChallenge
{
	public  static Class MarbleChallenge 
	{
		public static List<Marble> SortAndFilter(List<Marble> marbles)
	{
        Dictionary<String, int> colorLookup = new Dictionary<string, int>()
        {
            {"red", 1},
            {"orange", 2 },
            {"yellow", 3 },
            {"green",4},
            {"blue", 5 },
            {"indigo", 6 },
            {"violet", 7 }
        };
        List<Marbles> filteredMarbles = marbles.Where(m => m.Weight >= 0.5 && StringHelper.IsPalindrome(m.Name)).ToList();
        List<Marble> sortedMarbles = marbleList.OrderBy(m => colorLookup[m.Color]).ToList();
        return sortedMarbles; 
	}

   }
}
