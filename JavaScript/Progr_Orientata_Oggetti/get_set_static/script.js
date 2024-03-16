class Persona {
    constructor(name, annoNascita){
        this._nome = name
        this.annoNascita = annoNascita
    }

    get eta(){
        return 2024 - this.annoNascita
    }
    get nome(){
        return this._nome
    }
    set nomeCompleto(n){
        this._nome = n
    }
    // Un metodo statico è una proprieta che appartiene solo alla classe
    static saluta(){
        console.log("Ciao mondo, sono la persona")
    }
}

const mario = new Persona("Mario", 1999)
// console.log("età di Mario:",mario.eta)
mario.nomeCompleto = "Susanna"
// console.log("ora si chiama", mario.nome)

Persona.saluta()
