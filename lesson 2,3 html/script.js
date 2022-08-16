(function () {
    function sum (val) {
        let tempsum = val;
        sum = function() {
            let arg = arguments[0] ? arguments[0] : 0;
            return tempsum = tempsum + arg;
        };
        return sum();
    }
    console.log(sum(3)); 
    console.log(sum(8)); 
    console.log(sum(4)); 
});
(function () {
  //  let arr=[];
    function arr (val){
        let temparr =val ;
        arr = function(){
            if(val===''){
                arg=[];
                //delet array
             }
             arr.push(val)
            }
            return arr();
    }   
    
    console.log(sum(3)); 
    console.log(sum(5)); 
    console.log(sum({name:'name'})); 
    console.log(sum());
    console.lof(sum(5));
});
