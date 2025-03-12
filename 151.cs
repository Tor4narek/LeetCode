public class Solution {
    public string ReverseWords(string s)
     {
        s = s.Trim();
        s = s + ' ';
        var character = s.ToCharArray();
        var i = 1;
       var word = "";
        word += character[0];
        var res = new List<string>();
        var l = character.Length;
        while (i <l)
        {
          
            if(character[i] == ' ' && character[i-1] != ' ')
            {
               
                res.Add(word);
                word = "";
            }
            else if(character[i] != ' ' )
            {
                word += character[i];
            }

            i++;
        }
        
        res.Reverse();
        var resword = "";
        foreach (var w in res)
        {
            resword += w+' ';
        }
        return resword.Trim();

    }}



