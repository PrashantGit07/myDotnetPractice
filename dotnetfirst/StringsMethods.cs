// using System;
// class StringMethods
// {

    // public static void Main(string[] args)
    // {
        //compare ordinal - to compare two stings based on the numeric values of correspodning characters

        // string? s1 = "Hello";
        // string? s2 = "HelloIAMDavid";
        // string? s2 = "Mello";
        // string? s3 = "khello";
        // string[] s4 = { "he", "is", "from", "Lucknow" };

        // System.Console.WriteLine(string.CompareOrdinal(s2, s1));


        //Conact -  to add two or multiple strings

        // System.Console.WriteLine(string.Concat(s1," ",s2," ",s3," "));



        //conatains - returns boolean value if a string is presnent inside anothet string

        // System.Console.WriteLine(s1.Contains(s4));

        //Ends with- to check if a string ends with a particular set of characters
        // System.Console.WriteLine(s1.EndsWith(s4));
        // System.Console.WriteLine(s1.Equals(s5));


        //Remove - is used to get a new string after removing all the characters from specified bigindex till given lenght
        //if lenght is not specified , it removes all characters after bigIndex


        // System.Console.WriteLine(s2.Remove(4, 5));
        //it will start removing characters from index 4 and will remove 5 characters after 4th index


        //Replace - we can replace a character with another character and also we can replace a word in a string with another word


        //split - it returns an array of strings which is separated by spacses


        //isNullorEmpty
        //isNullorWhiteSpace - checks if a string is null or empty
        // System.Console.WriteLine(string.IsNullOrEmpty(s1));


        //join - is used to combine an array of strings using a specified charcater

        // System.Console.WriteLine(string.Join(" " , s4));


        // lastIndexOf - returns the last index of the the specified charcater
        // string s5 = "heheheheheloow";
        // System.Console.WriteLine(s5.LastIndexOf("h"));

        //lastIndexOfAny - we can find the last occurence of one or more character
        // char[] s6 = { 'h', 'e' };
        // System.Console.WriteLine(s5.LastIndexOfAny(s6));


        //trimEnd -  to remove all trailing characters from an string that are specified in an array
        // char[] s7 = { 'w' };
        // char[] s8 = { 'h' };
        // System.Console.WriteLine(s5.TrimEnd(s7));

        //trimStart - to remove all leading characters from an string that are specified in an array
        // System.Console.WriteLine(s5.TrimStart(s8));


        //toCharArray -  to  get characters from string in an array
        // char[] ans = s5.ToCharArray();
        // foreach (var i in ans)
        // {
        //     System.Console.Write(i + " ");
        // }



        //HashCode - A hash code of a string is a unique (ideally) number generated from the string's content. It's used for quick storage and retrieval of strings in data structures like hash tables.



        //getType - is used to return the type of current object , it returns System.Type object that represents the exact type of object and may provide extra info about the object
        // System.Console.WriteLine(s5.GetType());


        //getTypeCode - it returns the basic underlying type of the object
        // System.Console.WriteLine(s5.GetTypeCode());


        //insert() - it inserts any character into the current string on an specified index


        //PadLeft() - to increase width of the string or increase sequence of character in Left , we use padLeft(totalWidth , Paddingcharacter) , totalwidth means how many  characters i want in the resulting string, and character means we put the vharacter we want to add extra

        // System.Console.WriteLine(s5.PadLeft(20 , '+'));


        //PadRight() - same is with right padding
        // System.Console.WriteLine(s5.PadRight(20,'+'));

        //TolowerInvarient() - it is used to convert the letters into lower case using universal standards not according to user's local setting or language
        //same is with ToUppperVarient()
    // }

// }