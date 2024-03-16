const PersonProto = {
    calcolaEta(){
        console.log(2024-this.annoNascita)
    }
}

const p1 = Object.create(PersonProto)
console.log(p1)

p1.nome = "Giustino"

p1.annoNascita = 2002

p1.calcolaEta()
