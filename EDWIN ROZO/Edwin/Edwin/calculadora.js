function addition(num1,num2){
  addition=parseInt(num1 + num2);
  alert("The addition:" + addition);
}

function subtraction(num1,num2){
  subtraction=parseInt(num1 - num2);
  alert("The subtraction" + subtraction);
}

function multiplication(num1,num2){
  multiplication=parseInt(num1 * num2);
  alert("The multiplication:" + multiplication);
}

function division(num1,num2){
  division=parseInt(num1 / num2);
  alert("The division:" + division);
}

var num1=parseInt(prompt("Ingrese el numero"));
var signo=parseInt(prompt("Elija operación \n 1.Addition \n 2.Subtraction \n 3. Multiplication \n 4. Division"));
var num2=parseInt(prompt("Ingrese el numero"));

if (num2===0) {
  alert("error división undefine")
}
  else{
    switch (signo) {
      case 1:
      addition(num1,num2);
      break;
    case 2:
      subtraction(num1,num2);
      break;
      case 3:
      multiplication(num1,num2);
      break;
    case 4:
      division(num1,num2);
      break;
    default:
      break;
  }
}