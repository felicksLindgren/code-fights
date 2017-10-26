int shapeArea(int n) {
    var result = 1;
    for(var i = 0; i < n; i++){
        result += 4*i; 
    }
    return result;
}
