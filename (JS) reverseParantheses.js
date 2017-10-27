function flip(flipped){
    if(flipped.indexOf('(')>=0){
        var j=0;
        var a=0;
        var b=0;
        var reversed=[];
        while (j<flipped.length&&b==0) {
            if(flipped[j]=='('){
                 a=j;
            }
            else
                if(flipped[j]==')'){
                    flipped.splice(a,1);
                    flipped.splice(j-1,1);
                    b=j-1;
                }
            j++;
        }
        reversed=flipped.slice(a,b);
        reversed.reverse();
        for(var i=0;i<reversed.length;i++,a++){
            flipped[a]=reversed[i];
        }
        flip(flipped);
    }
    return flipped;
}

function reverseParentheses(s){
    return(flip(s.split("")).join(""));
}
