object sortByHeight(int[] a) {
    var i = 0;
    return a.Select(p => p >= 0 
                ? a.Where(_ => _ >= 0).OrderBy(_ => _).ToArray()[i++] 
                : -1).ToArray();
}
