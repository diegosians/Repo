// in javascript abbiamo la possibilita di creare oggetti 
// usando la funzione come costruttore 

const Persona = function(nome, annoNascita){
    this.nome = nome
    this.annoNascita = annoNascita
}

const persona1 = new Persona("Gino", "1992")


console.log(persona1 instanceof Persona)


// Prototypes
Persona.prototype.calcEta = function(){
    console.log(2024- this.annoNascita)
}

persona1.calcEta()

console.log(Persona.prototype.isPrototypeOf(persona1))

