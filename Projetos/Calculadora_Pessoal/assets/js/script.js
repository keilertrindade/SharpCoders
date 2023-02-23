const buttons = document.querySelectorAll("#calculator-buttons button");
const lastOperationText = document.getElementById("last-operation");
const resultText = document.getElementById("result");

class Calculator{
    constructor(lastOperationText, resultText){
        this.lastOperationText = lastOperationText;
        this.resultText = resultText;
        this.firstTerm = "";
        this.secondTerm = "";
        this.termControlator = 1;
        this.operator = null;
        this.result = "";
    }


    addDigit(value){
        if(this.termControlator == 1){
            this.firstTerm = this.firstTerm.toString();
            if(this.firstTerm.includes(".") && value == ".")
                return
            this.firstTerm += value;
        }

        if(this.termControlator == 2){
            this.secondTerm = this.secondTerm.toString();
            if(this.secondTerm.includes(".") && value == ".")
                return          
            this.secondTerm += value;
        }

        this.updateScreen();
    }

    processSymbol(value){

        switch(value){
            case "=":
                this.result = this.realizarCalculo(this.firstTerm, this.secondTerm, this.operator)
                break;
            case "CE":
                this.cleanScreen();
                break;
            case "+-":
                this.invertSignal();
                break;
            case "%":
                this.realizarPercent();
                break;
            default:
                this.operator = value;
                this.termControlator = 2;
            
        }
        this.updateScreen();
   }

   invertSignal(){
        if(this.termControlator == 1)
            this.firstTerm *= -1;
        else
            this.secondTerm *= -1;
}

   updateScreen(){

    if (this.operator != null){
        lastOperationText.innerText = `${this.firstTerm} ${this.operator} ${this.secondTerm}`
    }else{
        lastOperationText.innerText = this.firstTerm + " " + this.secondTerm;      
    }

    resultText.innerText = this.result;
}

   cleanScreen(){

        this.lastOperationText = "";
        this.resultText = "";
        this.firstTerm = "";
        this.secondTerm = "";
        this.operator = null;
        this.result = "";
        this.termControlator = 1;

}

realizarCalculo(firstTerm, secondTerm, operator){

    if(secondTerm == "" || operator == null){
        //alert("Digite todos os termos da operação")
        return "";
    }

        switch(operator){
            case "+":
                return parseFloat(firstTerm) + parseFloat(secondTerm);
                break;
            case "-":
                return parseFloat(firstTerm) - parseFloat(secondTerm);
                break;
            case "x":
                return parseFloat(firstTerm) * parseFloat(secondTerm);
                break;
            case "/":
                return parseFloat(firstTerm) / parseFloat(secondTerm);
                break;
        }
}

realizarPercent(){
    if(this.secondTerm == "" || this.operator == null){     
        return;
    }

    this.secondTerm = (this.firstTerm * this.secondTerm)/100;
}



}

const calculator = new Calculator(lastOperationText,resultText);

buttons.forEach( (btn) => {
    btn.addEventListener("click", (event) =>  {
        const value = event.target.innerText;
        
        if(value >= 0 || value === "."){         
            calculator.addDigit(value);
        }else{
            calculator.processSymbol(value);

        }

    })
})