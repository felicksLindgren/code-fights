string reverseParentheses(string s) {
    var l = s.LastIndexOf('(');
    if (l == -1) return s;
    var r = s.IndexOf(')', l);
    var arr = s.Substring(l + 1, r - l - 1).ToCharArray();
    Array.Reverse(arr);
    return reverseParentheses(s.Substring(0, l) + new string(arr) + s.Substring(r + 1));
}
