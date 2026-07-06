public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // I'm not sure what to comment, this is fairly straightforward.
        //  Initial thoughts: "is it from 0? or from 1?"
        //  Failed tests, found to start i at 1 rather than 0.
        // You are making a list of multiples, so multiply the number by
        //  an incremented count and return that list as an array, storing
        //  the results in a List.
        List<double> multipleList = new List<double>();

        for (int i = 1; i <= length; i++)
        {
            multipleList.Add(i * number);
        }

        return multipleList.ToArray(); // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Not sure what to comment, pretty straight forward.
        // I think Modulo would be a good use if this was a Right & Left function,
        //  not sure if C# supports that kind of syntax hack like py GetRange(data.Count % amount).
        //                                                           --> it doesnt.
        // Since it's only rotating right, get the rightmost number range and then insert at pos0.
        //   `amount' is the amount of numbers to get from the rightmost side, subtract the count
        //   of the list by the amount to get the range of numbers rotated in GetRange.
        // GetRange creates a shallow copy, we don't have to create a variable for that, insert
        //   it in the InsertRange method and remove the amount of numbers from the rightmost side.
        data.InsertRange(0, data.GetRange(data.Count - amount, amount));
        data.RemoveRange(data.Count - amount, amount);
    }
}
