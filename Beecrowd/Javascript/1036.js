var input = require('fs').readFileSync('1036', 'utf8');
var lines = input.split(' ');


var a = parseFloat(lines.shift());
var b = parseFloat(lines.shift());
var c = parseFloat(lines.shift());

var delta = (b * b) - 4 * a * c;

if (delta < 0 || a === 0){
    console.log("Impossivel calcular");
}else{
     var x1 = (-b + Math.sqrt(delta)) / (2 * a);
     var x2 = (-b - Math.sqrt(delta)) / (2 * a);
     
     console.log("R1 = " + x1.toFixed(5));
     console.log("R2 = " + x2.toFixed(5));
}