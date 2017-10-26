bool checkPalindrome(string inputString) {
    return inputString.SequenceEqual(inputString.Reverse());
}
