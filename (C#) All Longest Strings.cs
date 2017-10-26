string[] allLongestStrings(string[] list) {
    return list.Where(s => s.Length == list
               .OrderBy(w => w.Length)
               .LastOrDefault()
               .Length)
        .ToArray();
}
