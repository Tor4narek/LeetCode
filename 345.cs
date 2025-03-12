public class Solution {
    public string ReverseVowels(string s) {
        var l = s.Length;
       char[] wordList = s.ToCharArray();
        var vowelList = new List<Char>();
        var vowelIndexList = new List<int>();
        for(var i=0; i<l;i++){
            var ch = wordList[i];
            if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u' || ch=='A' || ch=='E' || ch=='I' || ch=='O' ||ch=='U' )
            {
                vowelList.Add(ch);
                vowelIndexList.Add(i);
            }
        }
        vowelIndexList.Reverse();
        var lv  = vowelList.Count;
        for(var i=0;i<lv;i++){
            wordList[vowelIndexList[i]]=vowelList[i];
        }
        return new String(wordList);

    }
}
