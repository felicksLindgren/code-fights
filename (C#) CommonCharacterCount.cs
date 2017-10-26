int commonCharacterCount(string s1, string s2) {
    var list = new List<char>();
    foreach (var w in s1)
    {
        if (s2.Contains(w)) {
            list.Add(w);
            s2 = s2.Remove(s2.IndexOf(w), 1);
        }
    }
    return list.Count();
}
