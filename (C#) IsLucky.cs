bool isLucky(int n) {
    return n.ToString().Substring(n.ToString().Length / 2).Sum(_ => _ -'0') == n.ToString().Remove(n.ToString().Length / 2).Sum(_ => _ - '0');
}
