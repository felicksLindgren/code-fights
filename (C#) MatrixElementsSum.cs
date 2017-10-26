int matrixElementsSum(int[][] matrix) {
    var result = 0;
    for (var i = 0; i < matrix[0].Length; i++) {
        for (var j = 0; j < matrix.Length; j++) {
            if (matrix[j][i] == 0) {
                break;
            }
            result += matrix[j][i];
        }
    }
    return result;
}
